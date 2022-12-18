using Common;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace transaction_coordinator
{
    /// <summary>
    /// An instance of this class is created for each service replica by the Service Fabric runtime.
    /// </summary>
    internal sealed class transaction_coordinator : StatefulService
    {
        public transaction_coordinator(StatefulServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (e.g., HTTP, Service Remoting, WCF, etc.) for this service replica to handle client or user requests.
        /// </summary>
        /// <remarks>
        /// For more information on service communication, see https://aka.ms/servicefabricservicecommunication
        /// </remarks>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceReplicaListener> CreateServiceReplicaListeners()
        {
            return new[]{
                new ServiceReplicaListener(context =>
                {
                    return new  WcfCommunicationListener<ITransactions>(context,
                            new transaction_service(this.StateManager),
                            WcfUtility.CreateTcpListenerBinding(),
                            "ServiceEndpoint"

                        );
                },"ServiceEndpoint")

                };
        }
        private async Task set_elements()
        {
            try
            {
                var users = await this.StateManager.GetOrAddAsync<IReliableDictionary<string, List<User>>>("users");
                using (var tx = this.StateManager.CreateTransaction())
                {
                    await users.TryAddAsync(tx, "users", new List<User>());
                    await tx.CommitAsync();
                }
                var departures = await this.StateManager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
                using (var tx = this.StateManager.CreateTransaction())
                {
                    await departures.TryAddAsync(tx, "departures", new List<Departure>());
                    await tx.CommitAsync();
                }
            }
            catch (Exception e) { }
        }
        /// <summary>
        /// This is the main entry point for your service replica.
        /// This method executes when this replica of your service becomes primary and has write status.
        /// </summary>
        /// <param name="cancellationToken">Canceled when Service Fabric needs to shut down this service replica.</param>
        protected override async Task RunAsync(CancellationToken cancellationToken)
        {
            // TODO: Replace the following sample code with your own logic 
            //       or remove this RunAsync override if it's not needed in your service.

            var myDictionary = await this.StateManager.GetOrAddAsync<IReliableDictionary<string, long>>("myDictionary");
            var users = await this.StateManager.GetOrAddAsync<IReliableDictionary<string, List<User>>>("users");
            var departures = await this.StateManager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
            await set_elements();

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var tx = this.StateManager.CreateTransaction())
                {
                    var result = await myDictionary.TryGetValueAsync(tx, "Counter");

                    ServiceEventSource.Current.ServiceMessage(this.Context, "Current Counter Value: {0}",
                        result.HasValue ? result.Value.ToString() : "Value does not exist.");

                    await myDictionary.AddOrUpdateAsync(tx, "Counter", 0, (key, value) => ++value);

                    // If an exception is thrown before calling CommitAsync, the transaction aborts, all changes are 
                    // discarded, and nothing is saved to the secondary replicas.
                    await tx.CommitAsync();
                }

                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }
        }
    }
}
