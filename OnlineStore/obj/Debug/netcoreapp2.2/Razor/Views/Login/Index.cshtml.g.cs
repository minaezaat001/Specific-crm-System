#pragma checksum "E:\projects\OnlineStore\OnlineStore\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15304b1bb7e5013de359c0caef3fb45e52f663f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "E:\projects\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore;

#line default
#line hidden
#line 2 "E:\projects\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15304b1bb7e5013de359c0caef3fb45e52f663f3", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85bb3a1f5b42cee7936e01fe8aebb63edeff1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineStore.Models.Login>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(77, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15304b1bb7e5013de359c0caef3fb45e52f663f33687", async() => {
                BeginContext(83, 383, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""css/vandors/bootstrap.min.css"">
    <!-- Fontawsome -->
    <link rel=""stylesheet"" href=""css/vandors/all.min.css"">
    <!-- Mian-Style -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <title>Logins</title>
");
                EndContext();
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
            EndContext();
            BeginContext(473, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(477, 10072, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15304b1bb7e5013de359c0caef3fb45e52f663f35273", async() => {
                BeginContext(483, 2346, true);
                WriteLiteral(@"
    <!-- ========================================================
    Start Main Header-->
    <header class=""main-header bg-main-color color-whait py-3 font-size"">
        <div class=""container"">
            <div class=""header-contanet d-flex"">
                <i class=""fa fa-bars click-pull open-nav-list""></i>
                <div class=""logo"">
                    <div class=""logo-text"">Store</div>
                </div>
            </div> <!-- ./ header-contanet-->
            <ul class=""list-nav bg-main-color p-5"">
                <li class=""list-item-nav click-pull mt-3"">
                    <a href=""admin.html"" class=""link-nav color-whait"">Products</a>
                </li>
                <li class=""list-item-nav click-pull mt-3 drop-pearnt"">
                    <a href=""logins.html"" class=""link-nav color-whait"">Logins</a>
                </li>
                <li class=""list-item-nav click-pull mt-3"">
                    <a href=""admin-order.html"" class=""link-nav color-whait"">Order");
                WriteLiteral(@"s</a>
                </li>
                <li class=""list-item-nav click-pull mt-3"">
                    <a href=""customer.html"" class=""link-nav color-whait"">Customers</a>
                </li>
                <li class=""list-item-nav click-pull mt-3"">
                    <a href=""users.html"" class=""link-nav color-whait"">Users</a>
                </li>
            </ul> <!-- ./list-nav -->
        </div>
    </header>
    <!-- ========================================================
    End Main Header-->

    <section class=""logins py-5"">
        <div class=""title text-center mb-5"">
            <h2 class=""title-page"">Logins</h2>
        </div>

        <div class=""container"">
            <!-- Start Btns  -->
            <ul class=""d-flex justify-content-center my-2 list-logins"">
                <li class=""mr-2"">
                    <a href=""#"" class=""mainColor p-2  link-longins login-active"" data-targets=""#today"">
                        To
                        Day
            ");
                WriteLiteral(@"        </a>
                </li>
                <li class=""mr-2"">
                    <a href=""#"" class=""mainColor p-2 link-longins "" data-targets=""#byname"">
                        Search By
                        Name
                    </a>
                </li>
                <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2829, "\"", 2837, 0);
                EndWriteAttribute();
                BeginContext(2838, 1892, true);
                WriteLiteral(@">
                    <a href=""#"" class=""mainColor p-2 link-longins "" data-targets=""#bydate"">
                        Search By
                        Date
                    </a>
                </li>
            </ul>
            <!-- End Btns -->
            <!-- ====================
            Logins Main Table -->
            <div class=""block table-responsive"" id=""today"">
                <table class=""table mt-5 mx-auto table-hover"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Id</th>
                            <th scope=""col"">User Name</th>
                            <th scope=""col"">Time</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>test</td>
                            <td>05:00</td>
                        </tr>
                        <tr>
           ");
                WriteLiteral(@"                 <td>2</td>
                            <td>test</td>
                            <td>05:00</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>test</td>
                            <td>05:00</td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>test</td>
                            <td>05:00</td>
                        </tr>
                    </tbody>
                </table> <!-- ./Main Table -->
            </div>
            <!-- ====================
                End Logins Main Table -->
            <!-- =====================
            Start Search By Name -->
            <div class=""hide-logins seacrh-by-name my-5"" id=""byname"">
                ");
                EndContext();
                BeginContext(4730, 329, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15304b1bb7e5013de359c0caef3fb45e52f663f310331", async() => {
                    BeginContext(4736, 316, true);
                    WriteLiteral(@"
                    <div class=""centet-by-name w-50 mx-auto"">
                        <input type=""text"" class=""w-100 border px-3 py-2"" placeholder=""Name"">
                        <i class=""fa fa-search mx-2 icon-search click-pull bg-main-color color-whait p-2""></i>
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
                BeginContext(5059, 1878, true);
                WriteLiteral(@"

                <!-- ====================
                Logins Main Table -->
                <div class=""block table-responsive"" id=""today"">
                    <table class=""table mt-5 mx-auto table-hover"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Id</th>
                                <th scope=""col"">User Name</th>
                                <th scope=""col"">Time</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                     ");
                WriteLiteral(@"       <tr>
                                <td>3</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                        </tbody>
                    </table> <!-- ./Main Table -->
                </div>
                <!-- ====================
                End Logins Main Table -->

            </div>
            <!-- =====================
            End Search By Name -->
            <!-- =====================
            Start Search By Date -->
            <div class=""hide-logins seacrh-by-date my-5"" id=""bydate"">
                ");
                EndContext();
                BeginContext(6937, 1179, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15304b1bb7e5013de359c0caef3fb45e52f663f314127", async() => {
                    BeginContext(6943, 1166, true);
                    WriteLiteral(@"
                    <div class=""contet-by-date"">
                        <div class=""row"">
                            <div class=""col-sm-5  mb-2 col-6"">
                                <label class=""mr-2 font-size "" for=""from"">From</label>
                                <input type=""date"" id=""from"" class=""w-75 border px-3 py-2"" placeholder=""From"">
                            </div>
                            <div class=""col-sm-5 mb-2 col-6"">
                                <label class=""mr-2 font-size "" for=""to"">To</label>
                                <input type=""date"" id=""to"" class=""w-75 border px-3 py-2"" placeholder=""To"">
                            </div>
                            <div class=""col-sm-2 mb-2 col-6 px-0"">
                                <button class=""btn border bg-main-color color-whait btn-min w-100"">
                                    Search
                                    <i class=""fa fa-search ml-2""></i>
                                </button>
           ");
                    WriteLiteral("                 </div>\r\n                        </div> <!-- ./row -->\r\n                    </div> <!-- ./centet-by-date -->\r\n                ");
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
                BeginContext(8116, 2426, true);
                WriteLiteral(@"
                <!-- End From -->
                <!-- ====================
                Logins Main Table -->
                <div class=""block table-responsive"" id=""today"">
                    <table class=""table mt-5 mx-auto table-hover"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Id</th>
                                <th scope=""col"">User Name</th>
                                <th scope=""col"">Time</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>test</td>
                                <td>05:00</td>
                       ");
                WriteLiteral(@"     </tr>
                            <tr>
                                <td>3</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>test</td>
                                <td>05:00</td>
                            </tr>
                        </tbody>
                    </table> <!-- ./Main Table -->
                </div>
                <!-- ====================
                End Logins Main Table -->
            </div>
            <!-- =====================
                End Search By Date -->

        </div> <!-- ./container -->

    </section>
    <!-- ================================================
    Start Main Footer -->

    <footer class=""py-3 footer bg-main-color color-whait bottom"">
        <div class=""text-center"">
            <span class=""copy-right font-size"">Copy R");
                WriteLiteral(@"ight &copy; 2020 Pnetworkers</span>
        </div>
    </footer>
    <!-- ================================================
    End Main Footer -->
    <!-- Laibiry-Jquery -->
    <script src=""js/vandors/jquery.js""></script>
    <!-- Bootstarp -->
    <script src=""js/vandors/bootstrap.min.js""></script>
    <!-- Main Script -->
    <script src=""js/main.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(10549, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineStore.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
