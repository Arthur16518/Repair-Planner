#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0f372e322183c761b3b9a5fa49c57f9ef08de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_UserData_UserData), @"mvc.1.0.view", @"/Views/Home/Components/UserData/UserData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0f372e322183c761b3b9a5fa49c57f9ef08de3", @"/Views/Home/Components/UserData/UserData.cshtml")]
    public class Views_Home_Components_UserData_UserData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repair_Planner.Data.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"user-data-container flex-box-vertical\">\r\n        <div class=\"avatar\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e0f372e322183c761b3b9a5fa49c57f9ef08de33339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 176, "~/Sources/avatar.jpg?v=", 176, 23, true);
#nullable restore
#line 7 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
AddHtmlAttributeValue("", 199, DateTime.Now.Millisecond, 199, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <h1>");
#nullable restore
#line 9 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
       Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 9 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
                             Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"text flex-item\">");
#nullable restore
#line 10 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
                             Write(await Component.InvokeAsync("OrganizationName", Model.OrganizationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text light-purple flex-item\">");
#nullable restore
#line 11 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
                                          Write(Model.eMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text light-purple flex-item\">+");
#nullable restore
#line 12 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\UserData\UserData.cshtml"
                                           Write(Model.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <div class=""flex-box-horizontal flex-item"">
            <a href=""/Account/SignOut""><button class=""button-purple"">??????????</button></a>
            <button class=""button-purple"" onclick=""CreateRequestCode()"">?????????????? ??????</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repair_Planner.Data.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
