#pragma checksum "C:\Users\Travis\Desktop\SDGKU Work\FSDI_110_ch4-master\Views\Catalog\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a743a14acde5e1c9a258b56e0645087e38585b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_register), @"mvc.1.0.view", @"/Views/Catalog/register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/register.cshtml", typeof(AspNetCore.Views_Catalog_register))]
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
#line 1 "C:\Users\Travis\Desktop\SDGKU Work\FSDI_110_ch4-master\Views\_ViewImports.cshtml"
using CarRental;

#line default
#line hidden
#line 2 "C:\Users\Travis\Desktop\SDGKU Work\FSDI_110_ch4-master\Views\_ViewImports.cshtml"
using CarRental.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a743a14acde5e1c9a258b56e0645087e38585b", @"/Views/Catalog/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98fc3369278e7291735a4d699d18e992ae639d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/register.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(20, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(26, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83a743a14acde5e1c9a258b56e0645087e38585b4755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(75, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(80, 157, true);
            WriteLiteral("\r\n<h1>Register new Car into the system.</h1>\r\n<div id=\"divAlert\" class=\"alert alert-success hide\" role=\"alert\">\r\n    The Car has been registered!\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(237, 2897, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a743a14acde5e1c9a258b56e0645087e38585b6383", async() => {
                BeginContext(243, 2884, true);
                WriteLiteral(@"
  <div class=""form-group row"">
    <label for=""Make"" class=""col-sm-2 col-form-label"">Make</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" id=""Make"" type=""text"" placeholder=""Make"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Model"" class=""col-sm-2 col-form-label"">Model</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""text"" id=""Model"" placeholder=""Model"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Year"" class=""col-sm-2 col-form-label"">Year</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""number"" id=""Year"" placeholder=""Year"">
    </div>
  </div>
       <div class=""form-group row"">
    <label for=""DailyPrice"" class=""col-sm-2 col-form-label"">DailyPrice</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""number"" id=""DailyPrice"" placeholder=""DailyPrice"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""Seats"" class=""col-sm-2 ");
                WriteLiteral(@"col-form-label"">Seats</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""number"" id=""Seats"" placeholder=""Seats"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""Color"" class=""col-sm-2 col-form-label"">Color</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""text"" id=""Color"" placeholder=""Color"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Mileage"" class=""col-sm-2 col-form-label"">Mileage</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""number"" id=""Mileage"" placeholder=""Mileage"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""ImageURL"" class=""col-sm-2 col-form-label"">Image URL</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" type=""text"" id=""ImageURL"" placeholder=""ImageURL"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Doors"" class=""col-sm-2 col-form-label"">Doors</label>
    <div class=""col-sm-10"">
      <i");
                WriteLiteral(@"nput class=""form-control"" type=""number"" id=""Doors"" placeholder=""Doors"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Cyls"" class=""col-sm-2 col-form-label"">Cylinders</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" id=""Cyls"" type=""number"" placeholder=""Cylinders"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""HP"" class=""col-sm-2 col-form-label"">Horse Power</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" id=""HP"" type=""number"" placeholder=""Horse Power"">
    </div>
  </div>
   <div class=""form-group row"">
    <label for=""Description"" class=""col-sm-2 col-form-label"">Description</label>
    <div class=""col-sm-10"">
      <input class=""form-control"" id=""Description"" type=""text"" placeholder=""Description"">
    </div>
  </div>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3134, 117, true);
            WriteLiteral("\r\n  <br><br><br><br>\r\n  <button type=\"button\" id=\"btnSave\" class=\"offset-4 btn btn-primary col-4\">Submit</button>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3270, 8, true);
                WriteLiteral("\r\n      ");
                EndContext();
                BeginContext(3278, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a743a14acde5e1c9a258b56e0645087e38585b11288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3318, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
            }
            );
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
