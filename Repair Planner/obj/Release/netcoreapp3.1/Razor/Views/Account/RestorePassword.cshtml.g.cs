#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Account\RestorePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f8a45ba17b3590a7ba8342802a2fa71038ae582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RestorePassword), @"mvc.1.0.view", @"/Views/Account/RestorePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8a45ba17b3590a7ba8342802a2fa71038ae582", @"/Views/Account/RestorePassword.cshtml")]
    public class Views_Account_RestorePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""restore-password-container"" class=""blurred-container"">
    <div id=""restore-password"" class=""window"">
        <svg class=""cross"" viewBox=""0 0 20 20"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" onclick=""CloseWindow('restore-password')"">
            <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M17.1688 19.3591C17.7606 19.953 18.72 19.953 19.3118 19.3591C19.9035 18.7651 19.9035 17.8022 19.3118 17.2083L12.2403 10.1227L19.5562 2.79175C20.1479 2.1978 20.148 1.23492 19.5562 0.640973C18.9644 0.0470207 18.005 0.0470207 17.4133 0.640973L10.0974 7.97193L2.58673 0.445423C1.995 -0.148474 1.03558 -0.148474 0.443797 0.445423C-0.147932 1.03937 -0.147932 2.00231 0.443797 2.5962L7.95451 10.1227L0.688279 17.4038C0.0965503 17.9977 0.0964952 18.9607 0.688279 19.5546C1.28001 20.1485 2.23943 20.1485 2.83121 19.5546L10.0974 12.2734L17.1688 19.3591Z"" fill=""#DCDCDC"" />
        </svg>
        <div id=""restore-pass-form"">
            <form action=""/Account/RestorePassword"" method=""post"" data-ajax=""true"" data-ajax-m");
            WriteLiteral(@"ode=""replace"" data-ajax-update=""#restore-pass-form"" style=""display: flex; flex-direction: column; align-items: center"">
                <p class=""text"" style=""margin: 1.5vh"">Введите свой логин или Email для восстановления пароля</p>
                <input required type=""text"" placeholder=""Логин или Email"" class=""text-box-lite"" name=""email"" style=""margin: 0"" />
                <button class=""button-purple"" type=""submit"" style=""margin-top: 3vh"">ОТПРАВИТЬ</button>
            </form>
        </div>
    </div>
</div>");
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
