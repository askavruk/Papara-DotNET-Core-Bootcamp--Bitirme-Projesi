#pragma checksum "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3108eaec0bcfbaff02746283d0b316601e47a4ea"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3108eaec0bcfbaff02746283d0b316601e47a4ea", @"/Views/Message/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca26f2978ec9d28812f490d8ce9d1e09b463a9f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetSendboxMessagesDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3108eaec0bcfbaff02746283d0b316601e47a4ea4273", async() => {
                WriteLiteral(@"

        <!-- Content Wrapper. Contains page content -->
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1>Mesajlar</h1>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>
        <!-- Main content -->
        <section class=""content"">
            <div class=""row"">
");
                WriteLiteral(@"                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card card-primary card-outline"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Gönderilen Mesajlar</h3>
                            <div class=""card-tools"">
                                <div class=""input-group input-group-sm"">
                                    <input type=""text"" class=""form-control"" placeholder=""Mail kutusunda ara"">
                                    <div class=""input-group-append"">
                                        <div class=""btn btn-primary"">
                                            <i class=""fas fa-search""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.card-tools -->
                        </div>
                        <!-- /.card-header -->
    ");
                WriteLiteral(@"                    <div class=""card-body p-0"">
                            <div class=""mailbox-controls"">
                                <!-- Check all button -->
                                <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                    <i class=""far fa-square""></i>
                                </button>
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-reply""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-share""></i></button>
                                </div>
                                <!-- /.btn-group -->
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-sy");
                WriteLiteral(@"nc-alt""></i></button>
                                <div class=""float-right"">
                                    1-50/200
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-left""></i></button>
                                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-right""></i></button>
                                    </div>
                                    <!-- /.btn-group -->
                                </div>
                                <!-- /.float-right -->
                            </div>
                            <div class=""table-responsive mailbox-messages"">
                                <table class=""table table-hover table-striped"">
                                    <tbody>
");
#nullable restore
#line 70 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                <div class=\"icheck-primary\">\r\n                                                    <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4081, "\"", 4089, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""check1"">
                                                    <label for=""check1""></label>
                                                </div>
                                            </td>
                                            <td class=""mailbox-star"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3108eaec0bcfbaff02746283d0b316601e47a4ea9274", async() => {
                    WriteLiteral("<i class=\"fas fa-star text-warning\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4372, "~/Message/MessageDetail/", 4372, 24, true);
#nullable restore
#line 79 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
AddHtmlAttributeValue("", 4396, item.MessageId, 4396, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                            <td class=\"mailbox-name\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3108eaec0bcfbaff02746283d0b316601e47a4ea11064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4542, "~/Message/MessageDetail/", 4542, 24, true);
#nullable restore
#line 80 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
AddHtmlAttributeValue("", 4566, item.MessageId, 4566, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 80 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                                                                                                      Write(item.RecevierMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td class=\"mailbox-subject\">\r\n                                                <b>");
#nullable restore
#line 82 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                              Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> - ");
#nullable restore
#line 82 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                                                  Write(item.MessageContent.Substring(0, 10));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"...
                                            </td>
                                            <td class=""mailbox-attachment""></td>
                                            <td class=""mailbox-date"">5 mins ago</td>
                                        </tr>
");
#nullable restore
#line 87 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\Message\Sendbox.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                                </table>
                                <!-- /.table -->
                            </div>
                            <!-- /.mail-box-messages -->
                        </div>
                        <!-- /.card-body -->
                        <div class=""card-footer p-0"">
                            <div class=""mailbox-controls"">
                                <!-- Check all button -->
                                <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                    <i class=""far fa-square""></i>
                                </button>
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""far fa-trash-alt""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-reply""></i></button>
              ");
                WriteLiteral(@"                      <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-share""></i></button>
                                </div>
                                <!-- /.btn-group -->
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-sync-alt""></i></button>
                                <div class=""float-right"">
                                    1-50/200
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-left""></i></button>
                                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fas fa-chevron-right""></i></button>
                                    </div>
                                    <!-- /.btn-group -->
                                </div>
                                <!-- /.float-right -->
                            </div>
          ");
                WriteLiteral("              </div>\r\n                    </div>\r\n                    <!-- /.card -->\r\n                </div>\r\n                <!-- /.col -->\r\n            </div>\r\n            <!-- /.row -->\r\n        </section>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n</html>");
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
