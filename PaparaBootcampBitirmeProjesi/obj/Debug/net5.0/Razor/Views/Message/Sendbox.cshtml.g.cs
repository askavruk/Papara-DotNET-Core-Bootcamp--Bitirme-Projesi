#pragma checksum "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc179f811df26d518d82f9d0cf633dd9c0411b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Sendbox), @"mvc.1.0.view", @"/Views/Message/Sendbox.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\_ViewImports.cshtml"
using PaparaBootcampBitirmeProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\_ViewImports.cshtml"
using PaparaBootcampBitirmeProjesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc179f811df26d518d82f9d0cf633dd9c0411b7", @"/Views/Message/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca26f2978ec9d28812f490d8ce9d1e09b463a9f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetSendboxMessagesDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMessageDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm("), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
  
    ViewData["Title"] = "Gönderilen Mesajlar";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Gönderilen Mesajlar</h1>\r\n\r\n<table class=\"table table-bordered\"\r\n    <tr>\r\n        <th>#</th>\r\n");
            WriteLiteral("        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Aç</th>\r\n        <th>Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
         foreach (var item in Model)
        {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n                                <th>");
#nullable restore
#line 24 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("                                <th>\r\n");
#nullable restore
#line 32 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                     if (item.Subject != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                   Write(item.Subject);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </th>\r\n                                <th> ");
#nullable restore
#line 37 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                Write(item.CreationDate.ToString("dd.MMMM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc179f811df26d518d82f9d0cf633dd9c0411b78401", async() => {
                WriteLiteral("Mesajı Aç");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                                                                                 WriteLiteral(item.MessageId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc179f811df26d518d82f9d0cf633dd9c0411b711096", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                                                                             WriteLiteral(item.MessageId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("Mesajı", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("silmek", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("istediğinize", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("emin", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("misiniz?\')\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetSendboxMessagesDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
