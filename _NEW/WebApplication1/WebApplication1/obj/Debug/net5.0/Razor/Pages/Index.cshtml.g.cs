#pragma checksum "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df3a9678a7d293e647acd8a9ed72e2b9311b880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df3a9678a7d293e647acd8a9ed72e2b9311b880", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pdfediting.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df3a9678a7d293e647acd8a9ed72e2b9311b8804575", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0df3a9678a7d293e647acd8a9ed72e2b9311b8805016", async() => {
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
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://unpkg.com/pdf-lib/dist/pdf-lib.js"" />
    <link href=""https://fonts.googleapis.com/css2?family=Palanquin&display=swap"" rel=""stylesheet"">
    <script src=""https://kit.fontawesome.com/19009d6c71.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/pdf-lib/dist/pdf-lib.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <title>PDF Editor</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df3a9678a7d293e647acd8a9ed72e2b9311b8807443", async() => {
                WriteLiteral(@"
    <div class=""application-container"">
        <!-- Header Section -->
        <header class=""header"">
            <h1>PDF Editor +</h1>
        </header>
        <!-- Toolbar Section -->
        <div class=""toolbar"">

            <div class=""toolkit"" id=""toolbar1"">
                <div class=""toolkit-title-container"">
                    <h1>Text</h1>
                </div>
                <div id=""text-controls-container"">
                    <select name=""fonts"" id=""fonts-input"">
                        <option value=""Times New Roman"">Times New Roman</option>
                        <option value=""Roboto"">Roboto</option>
                        <option value=""Montessorat"">Montessorat</option>
                    </select>
                    <input type=""number"" name=""number"" id=""number-input"" value=""14"">
                    <div class=""color-container"">
                        <input type=""color"" name=""color"" id=""color-picker"" value=""#fff"">
                    </div>
             ");
                WriteLiteral(@"   </div>
            </div>

            <div class=""toolkit"" id=""toolbar2"">
                <div class=""toolkit-title-container"">
                    <h1>Media</h1>
                </div>
                <div class=""media-controls-container"">
                    <button class=""media-icon"" id=""file-button"">
                        <i class=""fas fa-file blueiconcolor"" id=""file-icon""></i>
                    </button>
                    <button class=""media-icon"" id=""audio-button"">
                        <i class=""fas fa-play"" id=""audio-icon""></i>
                    </button>
                    <button class=""media-icon"" id=""video-button"">
                        <i class=""fas fa-video"" id=""video-icon""></i>
                    </button>
                </div>
            </div>

            <div class=""toolkit"" id=""toolkit3"">
                <div class=""toolkit-title-container"">
                    <h1>PDF Controls</h1>
                </div>
                <div class=""media-contro");
                WriteLiteral(@"ls-container"">
                    <button class=""media-icon"" id=""new-pdf-doc-button"">
                        <i class=""fas fa-plus""></i>
                    </button>
                    <button class=""media-icon"" >
                        <i class=""far fa-save""></i>
                    </button>
                    <button class=""media-icon"">
                        <i class=""far fa-folder-open""></i>
                    </button>
                </div>
            </div>
        </div>

        <!-- Main Content Section -->
        <div class=""main"">
            <iframe src=""https://pdf-lib.js.org/assets/with_update_sections.pdf"" id=""frame"" frameborder=""1"" width=""100%"" height=""100%""></iframe>
        </div>

    </div>

    <!--Choose an Audio File Modal-->
    <div id=""myModal"" class=""modal"">
        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""exit-container"">
                <span class=""close"">&times;</span>
            </div>
          ");
                WriteLiteral(@"  <div id=""modal-header"">
                <h3>Select an audio file</h3>
            </div>
            <div class=""audio-file-table"">
                <table>
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                    </tr>

");
#nullable restore
#line 107 "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml"
                     foreach (var audio in Model.Audios)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 110 "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml"
                           Write(audio.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 111 "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml"
                           Write(audio.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 113 "C:\Users\n16611\OneDrive - Neenah\Documents\2021 Assignments\Cap\pdf_capstone\_NEW\WebApplication1\WebApplication1\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <!--Save audio modal-->
    <div id=""save-modal"" class=""modal"">
        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""exit-container"">
                <span class=""close"">&times;</span>
            </div>
            <div id=""modal-header"">
                <h3>Select an audio file</h3>
            </div>
            <div class=""audio-file-table"">
                <form>
                    <input type=""text"" placeholder=""Enter file name""/>
                    <input type=""submit"" value=""Submit""/>
                </form>
            </div>
        </div>
    </div>

    <!--Scripts for the website-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df3a9678a7d293e647acd8a9ed72e2b9311b88013410", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df3a9678a7d293e647acd8a9ed72e2b9311b88014510", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel>)PageContext?.ViewData;
        public WebApplication1.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
