#pragma checksum "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "822ae212dd96d1afb0bdd32619377d887e9a40d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Odaberi), @"mvc.1.0.view", @"/Views/Takmicenje/Odaberi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Odaberi.cshtml", typeof(AspNetCore.Views_Takmicenje_Odaberi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"822ae212dd96d1afb0bdd32619377d887e9a40d5", @"/Views/Takmicenje/Odaberi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f6eb31d1c8637546d58ee5a6164dbc58c0c748", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Odaberi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RS1_2020_01_30.ViewModels.TakmicenjeOdaberiVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Takmicenje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezultat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
  
    ViewData["Title"] = "Odaberi";

#line default
#line hidden
            BeginContext(99, 103, true);
            WriteLiteral("\r\n<h4>Prikaz takmičenja</h4>\r\n<br />\r\n<div >\r\n    <label class=\"control-label\">Škola domaćin: </label> ");
            EndContext();
            BeginContext(203, 11, false);
#line 10 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
                                                    Write(Model.Skola);

#line default
#line hidden
            EndContext();
            BeginContext(214, 58, true);
            WriteLiteral("<br />\r\n    <label class=\"control-label\">Razred: </label> ");
            EndContext();
            BeginContext(273, 12, false);
#line 11 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
                                             Write(Model.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(285, 414, true);
            WriteLiteral(@"<br />
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>TakmičenjeID</th>
            <th>Predmet</th>
            <th>Razred</th>
            <th>Datum</th>
            <th>Broj ucenika koji nisu pristupili</th>
            <th>Najbolji ucenik (Skola | Odjeljenje | Ime i prezime)</th>
            <th>Akcija</th>
        </tr>

    </thead>
    <tbody>
        
        
");
            EndContext();
#line 30 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
     foreach (var x in Model.redovi)
    {

#line default
#line hidden
            BeginContext(744, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(775, 14, false);
#line 33 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.TakmicenjeID);

#line default
#line hidden
            EndContext();
            BeginContext(789, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(813, 9, false);
#line 34 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(822, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(846, 8, false);
#line 35 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(854, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(878, 7, false);
#line 36 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(885, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(909, 31, false);
#line 37 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.BrojUcenikaKojiNisuPristupili);

#line default
#line hidden
            EndContext();
            BeginContext(940, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(964, 10, false);
#line 38 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
           Write(x.Najbolji);

#line default
#line hidden
            EndContext();
            BeginContext(974, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1015, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cbeb44269d42efac92dc75f569ee3d", async() => {
                BeginContext(1099, 9, true);
                WriteLiteral("Rezultati");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
                                                                       WriteLiteral(x.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1112, 40, true);
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
    }

#line default
#line hidden
            BeginContext(1159, 35, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1194, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe78ad89bef4f9ab3aad3767621e992", async() => {
                BeginContext(1298, 7, true);
                WriteLiteral("Dodaj  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Emir\Desktop\Zadatak3\Rješenje\RS1_2020_01_30\Views\Takmicenje\Odaberi.cshtml"
                                                                                WriteLiteral(Model.SkolaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1309, 18, true);
            WriteLiteral("  \r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RS1_2020_01_30.ViewModels.TakmicenjeOdaberiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
