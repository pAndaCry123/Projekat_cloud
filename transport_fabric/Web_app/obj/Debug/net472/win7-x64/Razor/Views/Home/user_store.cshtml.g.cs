#pragma checksum "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0fed498923d8e41b1762fa29a753ed883374f8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_user_store), @"mvc.1.0.view", @"/Views/Home/user_store.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/user_store.cshtml", typeof(AspNetCore.Views_Home_user_store))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\_ViewImports.cshtml"
using Web_app;

#line default
#line hidden
#line 2 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\_ViewImports.cshtml"
using Web_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fed498923d8e41b1762fa29a753ed883374f8e", @"/Views/Home/user_store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edff2a08dd9e6f7d4e1ad5432d31444ad8d81f16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_user_store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "none", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autobus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Plane", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Train", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("filter_departures"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter_departures"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("purchase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("cancel_ticket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("filter_history"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("add_departure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 51, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h1>Summary furture departure</h1>\r\n");
            EndContext();
            BeginContext(59, 395, true);
            WriteLiteral(@"        <table class=""table table-hover table-dark"">
            <tr>
                <th>Id</th>
                <th>Transport type</th>
                <th>Ticket price</th>
                <th>Total tickets</th>
                <th>Rest free tickets</th>
                <th>Departure day</th>
                <th>Return day</th>
                <th>Weather</th>
            </tr>
");
            EndContext();
#line 17 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
             foreach (Common.Departure item in (IEnumerable<Common.Departure>)ViewBag.departures)
            {

#line default
#line hidden
            BeginContext(568, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(616, 7, false);
#line 20 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                    Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(623, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(655, 9, false);
#line 21 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.type);

#line default
#line hidden
            EndContext();
            BeginContext(664, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(696, 17, false);
#line 22 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.ticket_price);

#line default
#line hidden
            EndContext();
            BeginContext(713, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(745, 18, false);
#line 23 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.total_tickets);

#line default
#line hidden
            EndContext();
            BeginContext(763, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(795, 22, false);
#line 24 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.free_ticket_slots);

#line default
#line hidden
            EndContext();
            BeginContext(817, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(849, 18, false);
#line 25 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.day_departure);

#line default
#line hidden
            EndContext();
            BeginContext(867, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(899, 16, false);
#line 26 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.return_date);

#line default
#line hidden
            EndContext();
            BeginContext(915, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(947, 12, false);
#line 27 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.weather);

#line default
#line hidden
            EndContext();
            BeginContext(959, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
            }

#line default
#line hidden
            BeginContext(1004, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
            BeginContext(1024, 91, true);
            WriteLiteral("        <div class=\"form-group row\">\r\n            <p>You can filter this:</p>\r\n            ");
            EndContext();
            BeginContext(1115, 784, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e12396", async() => {
                BeginContext(1219, 92, true);
                WriteLiteral("\r\n                <select class=\"col-lg-2\" id=\"transport\" name=\"type\">\r\n                    ");
                EndContext();
                BeginContext(1311, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e12879", async() => {
                    BeginContext(1332, 5, true);
                    WriteLiteral("Empty");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1346, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1368, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e14364", async() => {
                    BeginContext(1392, 7, true);
                    WriteLiteral("Autobus");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1408, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1430, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e15851", async() => {
                    BeginContext(1452, 5, true);
                    WriteLiteral("Plane");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1466, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1488, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e17336", async() => {
                    BeginContext(1510, 5, true);
                    WriteLiteral("Train");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1524, 368, true);
                WriteLiteral(@"


                </select>
                <input class=""col-lg-2"" type=""date"" name=""departure_day"" />
                <input class=""col-lg-2"" type=""checkbox"" name=""free_tickets"" id=""free_tickets""/>
                <label class=""col-lg-2"" for=""free_tickets"">Tickets</label>
                <input class=""col-lg-1"" type=""submit"" value=""Search"" />
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1899, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(1928, 72, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"form-group row\">\r\n    <p>Create purchase</p>\r\n    ");
            EndContext();
            BeginContext(2000, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e20991", async() => {
                BeginContext(2038, 340, true);
                WriteLiteral(@"
        <input class=""col-lg-2"" type=""text"" name=""username"" placeholder=""Username"" />
        <input class=""col-lg-2"" type=""number"" name=""id_departure"" placeholder=""Id departure"" />
        <input class=""col-lg-2"" type=""number"" name=""count"" placeholder=""Count"" />
        <input class=""col-lg-1"" type=""submit"" value=""Purchase"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2385, 85, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"form-group row\">\r\n    <p>Cancel purchashed ticket</p>\r\n    ");
            EndContext();
            BeginContext(2470, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e23189", async() => {
                BeginContext(2513, 166, true);
                WriteLiteral("\r\n        <input class=\"col-lg-2\" type=\"number\" name=\"purchase_id\" placeholder=\"Purchase id\" />\r\n        <input class=\"col-lg-1\" type=\"submit\" value=\"Cancel\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2686, 67, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n<div>\r\n    <h1>Summary history purchases</h1>\r\n");
            EndContext();
            BeginContext(2761, 194, true);
            WriteLiteral("        <table class=\"table table-dark table-hover\">\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Departure id</th>\r\n                <th>Username</th>\r\n            </tr>\r\n");
            EndContext();
#line 86 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
             foreach (Common.Purchase item in (IEnumerable<Common.Purchase>)ViewBag.history)
            {

#line default
#line hidden
            BeginContext(3064, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(3112, 16, false);
#line 89 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                    Write(item.purchase_id);

#line default
#line hidden
            EndContext();
            BeginContext(3128, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3160, 17, false);
#line 90 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.departure_id);

#line default
#line hidden
            EndContext();
            BeginContext(3177, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3209, 13, false);
#line 91 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
                   Write(item.username);

#line default
#line hidden
            EndContext();
            BeginContext(3222, 32, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 94 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\Home\user_store.cshtml"
            }

#line default
#line hidden
            BeginContext(3269, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
            BeginContext(3289, 45, true);
            WriteLiteral("        <p>You can filter this:</p>\r\n        ");
            EndContext();
            BeginContext(3334, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e27486", async() => {
                BeginContext(3398, 332, true);
                WriteLiteral(@"
            <input type=""checkbox"" name=""departure_day"" id=""departure_day"" />
            <label for=""departure_day"">Departures</label>
            <input type=""checkbox"" name=""free_tickets"" id=""free_tickets"" />
            <label for=""free_tickets"">Tickets</label>
            <input type=""submit"" value=""Search"" />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3737, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3748, 83, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<div class=\"form-group row\">\r\n    <p>You can filter this:</p>\r\n    ");
            EndContext();
            BeginContext(3831, 945, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e29854", async() => {
                BeginContext(3922, 81, true);
                WriteLiteral("\r\n        <select class=\"col-lg-2\" id=\"transport\" name=\"transport\">\r\n            ");
                EndContext();
                BeginContext(4003, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e30326", async() => {
                    BeginContext(4024, 5, true);
                    WriteLiteral("Empty");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4038, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4052, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e31803", async() => {
                    BeginContext(4076, 7, true);
                    WriteLiteral("Autobus");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4092, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4106, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e33282", async() => {
                    BeginContext(4128, 5, true);
                    WriteLiteral("Plane");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4142, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4156, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fed498923d8e41b1762fa29a753ed883374f8e34759", async() => {
                    BeginContext(4178, 5, true);
                    WriteLiteral("Train");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4192, 577, true);
                WriteLiteral(@"
        </select>
        <input class=""col-lg-2"" type=""date"" name=""departure_day"" />
        <input class=""col-lg-2"" type=""number"" name=""ticket_price"" id=""ticket_price"" placeholder=""Ticket price"" />
        <input class=""col-lg-2"" type=""number"" name=""total_tickets"" id=""total_tickets"" placeholder=""Total tickets"" />
        <input class=""col-lg-2"" type=""number"" name=""lat"" id=""lat"" placeholder=""Lat"" />
        <input class=""col-lg-2"" type=""number"" name=""lon"" id=""lon"" placeholder=""Lon"" />

        <input class=""col-lg-1"" type=""submit"" value=""Add departure"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4776, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
