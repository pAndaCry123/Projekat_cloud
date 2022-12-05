using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace depart_statefull
{
    public class dep_service : IDepratire
    {
        dep_table_context context;
        List<Tuple<int, int>> lat_lon = new List<Tuple<int, int>>()
        {
            new Tuple<int, int>(45,19),
            new Tuple<int, int>(44,20),
            new Tuple<int, int>(42,18),
            new Tuple<int, int>(43,13),

        };
        public dep_service()
        {
            context = new dep_table_context();
            
            add();
        }


        private async void add()
        {
            for (int i = 0; i < 10; i++)
            {
                Departure dd = new Departure(i.ToString()) { id = i+1 };
                dd.type = ((type_transport)(i % 3)).ToString();
                dd.day_departure = DateTime.Now.AddDays(i).ToShortDateString();
                dd.return_date = DateTime.Now.AddDays(10 + i).ToShortDateString();
                dd.ticket_price = (i + 1) * 20;
                dd.total_tickets = 10;
                dd.free_ticket_slots = 10;
                dd.weather = await weather_get(i % 4);
                context.add_user(dd);
            }
        }
        private async Task<string> weather_get(int index)
        {
            HttpClient req = new HttpClient();
            var uri = string.Format("https://fcc-weather-api.glitch.me/api/current?lat={0}&lon={0}",lat_lon[index].Item1,lat_lon[index].Item2);

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");


            HttpResponseMessage response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            string[] data = responseBody.Split(',');
            return data[3].Split(':')[1];
        }


        public async Task<List<Departure>> return_all_departures()
        {
            return await context.retrun_all_departures();
        }

        public async Task<List<Departure>> return_filtered_departures(string type, string tickets, DateTime date)
        {
            return await context.retrun_filtered_departures(type, tickets, date);
        }

        public async Task<Departure> return_departure(int id_deparute, int count)
        {
            return await context.retrun_one_departure(id_deparute, count);
        }

        public async Task update_deprature(int id_deparute, int count)
        {
            await context.update_departure(id_deparute, count);
        }
    }
}
