#pragma checksum "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f74799898afa59f1bd6a614fa9e573a6088f5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f74799898afa59f1bd6a614fa9e573a6088f5e5", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edff2a08dd9e6f7d4e1ad5432d31444ad8d81f16", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(130, 51, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h1>Summary furture departure</h1>\r\n");
            EndContext();
            BeginContext(189, 395, true);
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
#line 22 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
             foreach (Common.Departure item in (IEnumerable<Common.Departure>)ViewBag.departures)
            {

#line default
#line hidden
            BeginContext(698, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(746, 7, false);
#line 25 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                    Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(753, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(785, 9, false);
#line 26 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.type);

#line default
#line hidden
            EndContext();
            BeginContext(794, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(826, 17, false);
#line 27 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.ticket_price);

#line default
#line hidden
            EndContext();
            BeginContext(843, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(875, 18, false);
#line 28 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.total_tickets);

#line default
#line hidden
            EndContext();
            BeginContext(893, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(925, 22, false);
#line 29 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.free_ticket_slots);

#line default
#line hidden
            EndContext();
            BeginContext(947, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(979, 18, false);
#line 30 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.day_departure);

#line default
#line hidden
            EndContext();
            BeginContext(997, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1029, 16, false);
#line 31 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.return_date);

#line default
#line hidden
            EndContext();
            BeginContext(1045, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1077, 12, false);
#line 32 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.weather);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1134, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
            BeginContext(1154, 91, true);
            WriteLiteral("        <div class=\"form-group row\">\r\n            <p>You can filter this:</p>\r\n            ");
            EndContext();
            BeginContext(1245, 785, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e512318", async() => {
                BeginContext(1349, 92, true);
                WriteLiteral("\r\n                <select class=\"col-lg-2\" id=\"transport\" name=\"type\">\r\n                    ");
                EndContext();
                BeginContext(1441, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e512801", async() => {
                    BeginContext(1462, 5, true);
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
                BeginContext(1476, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1498, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e514286", async() => {
                    BeginContext(1522, 7, true);
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
                BeginContext(1538, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1560, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e515773", async() => {
                    BeginContext(1582, 5, true);
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
                BeginContext(1596, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1618, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e517258", async() => {
                    BeginContext(1640, 5, true);
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
                BeginContext(1654, 369, true);
                WriteLiteral(@"


                </select>
                <input class=""col-lg-2"" type=""date"" name=""departure_day"" />
                <input class=""col-lg-2"" type=""checkbox"" name=""free_tickets"" id=""free_tickets"" />
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
            BeginContext(2030, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(2059, 72, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"form-group row\">\r\n    <p>Create purchase</p>\r\n    ");
            EndContext();
            BeginContext(2131, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e520914", async() => {
                BeginContext(2169, 340, true);
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
            BeginContext(2516, 85, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"form-group row\">\r\n    <p>Cancel purchashed ticket</p>\r\n    ");
            EndContext();
            BeginContext(2601, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e523112", async() => {
                BeginContext(2644, 166, true);
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
            BeginContext(2817, 67, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n<div>\r\n    <h1>Summary history purchases</h1>\r\n");
            EndContext();
            BeginContext(2892, 194, true);
            WriteLiteral("        <table class=\"table table-dark table-hover\">\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Departure id</th>\r\n                <th>Username</th>\r\n            </tr>\r\n");
            EndContext();
#line 91 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
             foreach (Common.Purchase item in (IEnumerable<Common.Purchase>)ViewBag.history)
            {

#line default
#line hidden
            BeginContext(3195, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(3243, 16, false);
#line 94 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                    Write(item.purchase_id);

#line default
#line hidden
            EndContext();
            BeginContext(3259, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3291, 17, false);
#line 95 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.departure_id);

#line default
#line hidden
            EndContext();
            BeginContext(3308, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3340, 13, false);
#line 96 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
                   Write(item.username);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 32, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Korisnik\Desktop\Projekat_cloud\transport_fabric\Web_app\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3400, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
            BeginContext(3420, 45, true);
            WriteLiteral("        <p>You can filter this:</p>\r\n        ");
            EndContext();
            BeginContext(3465, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e527384", async() => {
                BeginContext(3529, 332, true);
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
            BeginContext(3868, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3879, 84, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<div class=\"form-group crow\">\r\n    <p>You can filter this:</p>\r\n    ");
            EndContext();
            BeginContext(3963, 1018, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e529754", async() => {
                BeginContext(4054, 81, true);
                WriteLiteral("\r\n        <select class=\"col-lg-2\" id=\"transport\" name=\"transport\">\r\n            ");
                EndContext();
                BeginContext(4135, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e530226", async() => {
                    BeginContext(4156, 5, true);
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
                BeginContext(4170, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4184, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e531703", async() => {
                    BeginContext(4208, 7, true);
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
                BeginContext(4224, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4238, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e533182", async() => {
                    BeginContext(4260, 5, true);
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
                BeginContext(4274, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(4288, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f74799898afa59f1bd6a614fa9e573a6088f5e534659", async() => {
                    BeginContext(4310, 5, true);
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
                BeginContext(4324, 650, true);
                WriteLiteral(@"
        </select><br /><br />
        <input class=""col-lg-2"" type=""date"" name=""departure_day"" /> <br /><br />
        <input class=""col-lg-2"" type=""number"" name=""ticket_price"" id=""ticket_price"" placeholder=""Ticket price"" /><br /><br />
        <input class=""col-lg-2"" type=""number"" name=""total_tickets"" id=""total_tickets"" placeholder=""Total tickets"" /><br /><br />
        <input class=""col-lg-2"" type=""number"" name=""lat"" id=""lat"" placeholder=""Lat"" /><br /><br />
        <input class=""col-lg-2"" type=""number"" name=""lon"" id=""lon"" placeholder=""Lon"" /><br /><br />

        <input class=""col-lg-2"" type=""submit"" value=""Add departure"" />
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
            BeginContext(4981, 8, true);
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
