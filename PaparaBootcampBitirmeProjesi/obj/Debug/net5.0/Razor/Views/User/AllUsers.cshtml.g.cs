#pragma checksum "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d90bf748414c392adc0e0f196661a656c2949fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AllUsers), @"mvc.1.0.view", @"/Views/User/AllUsers.cshtml")]
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
#line 5 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d90bf748414c392adc0e0f196661a656c2949fc", @"/Views/User/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca26f2978ec9d28812f490d8ce9d1e09b463a9f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetUsersWithApartmentDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Site Sakinleri</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Blok</th>
                        <th>Daire</th>
                        <th>Daire Tipi</th>
                        <th>Ad Soyad</th>
                        <th>Email</th>
                        <th>Telefon</th>
                        <th>Ara?? Bilgisi</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 30 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 34 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                 if (item.Apartment != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                               Write(item.Apartment.Block);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                         
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 40 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                 if (item.Apartment != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                               Write(item.Apartment.ApartmentNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                               
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 46 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                 if (item.Apartment != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                               Write(item.Apartment.Type);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                        
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                           Write(item.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 56 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                 if (item.Vehicle != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                               Write(item.Vehicle.Brand);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                    Write(item.Vehicle.Model);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                                        Write(item.Vehicle.LicensePlate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                                                                                                       
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Asena Sevnur Ulun\Desktop\Papara-Bitirme Projesi\PaparaBootcampBitirmeProjesi\PaparaBootcampBitirmeProjesi\Views\User\AllUsers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetUsersWithApartmentDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
