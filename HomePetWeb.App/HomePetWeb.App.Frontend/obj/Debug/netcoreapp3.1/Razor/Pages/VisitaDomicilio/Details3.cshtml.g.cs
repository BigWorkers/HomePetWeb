#pragma checksum "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa237411ba082de8bb6337acb30725a1bddb4ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HomePetWeb.App.Frontend.Pages.VisitaDomicilio.Pages_VisitaDomicilio_Details3), @"mvc.1.0.razor-page", @"/Pages/VisitaDomicilio/Details3.cshtml")]
namespace HomePetWeb.App.Frontend.Pages.VisitaDomicilio
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\_ViewImports.cshtml"
using HomePetWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa237411ba082de8bb6337acb30725a1bddb4ce5", @"/Pages/VisitaDomicilio/Details3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a9175afd8ff35691895a364d6c428b724a56e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VisitaDomicilio_Details3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
Write(Model.VisitaDomicilio.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<p >                                                </p> 

<a class=""btn btn-primary"">DETALLE DE VISITA DOMICILIO</a>
<p >                                                </p> 
<p >                                                </p> 


<div>
    Id: ");
#nullable restore
#line 14 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
   Write(Model.VisitaDomicilio.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    Temperatura: ");
#nullable restore
#line 17 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
            Write(Model.VisitaDomicilio.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div>\r\n    Peso: ");
#nullable restore
#line 20 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
     Write(Model.VisitaDomicilio.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    FrecuenciaRespiratoria: ");
#nullable restore
#line 23 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
                       Write(Model.VisitaDomicilio.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    FrecuenciaCardiaca: ");
#nullable restore
#line 26 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
                   Write(Model.VisitaDomicilio.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div>\r\n    EstadoAnimo: ");
#nullable restore
#line 29 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
            Write(Model.VisitaDomicilio.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    FechaVisita: ");
#nullable restore
#line 32 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
            Write(Model.VisitaDomicilio.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    IdVeterinario: ");
#nullable restore
#line 35 "C:\HomePetWeb\HomePetWeb.App\HomePetWeb.App.Frontend\Pages\VisitaDomicilio\Details3.cshtml"
              Write(Model.VisitaDomicilio.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa237411ba082de8bb6337acb30725a1bddb4ce56626", async() => {
                WriteLiteral("Visita Domicilio ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePetWeb.App.Frontend.Pages.Details3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomePetWeb.App.Frontend.Pages.Details3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomePetWeb.App.Frontend.Pages.Details3Model>)PageContext?.ViewData;
        public HomePetWeb.App.Frontend.Pages.Details3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
