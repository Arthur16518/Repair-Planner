#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f0bcaaa4794094d8531358cd3da5574166c3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f0bcaaa4794094d8531358cd3da5574166c3b3", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sources/scripts/jquery-3.5.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sources/scripts/jquery.unobtrusive-ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f0bcaaa4794094d8531358cd3da5574166c3b34324", async() => {
                WriteLiteral("\r\n    <title>Repair Planner</title>\r\n    <meta charset=\"utf-8\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38f0bcaaa4794094d8531358cd3da5574166c3b34657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 133, "~/Sources/css/style.css?v=", 133, 26, true);
#nullable restore
#line 7 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 159, DateTime.Now.Millisecond, 159, 25, false);

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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f0bcaaa4794094d8531358cd3da5574166c3b36316", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 207, "~/Sources/scripts/script.js?v=", 207, 30, true);
#nullable restore
#line 8 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 237, DateTime.Now.Millisecond, 237, 25, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f0bcaaa4794094d8531358cd3da5574166c3b37986", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f0bcaaa4794094d8531358cd3da5574166c3b39172", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
#nullable restore
#line 12 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
 if (ViewData["userOrganization"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""gradient-container org-signUp-Back"">
        <div id=""org-signUp-window"" class=""window org-signUp-window"">
            <h1>?????????? ????????????????????!</h1>
            <p class=""text"" style=""margin: 2vh 0;"">????????????, ???? ???? ?????????? ?????? ?????????????????????? ?????? ?????????????????????? ?????? ?????????? ????????????????. ?????? ????????????????, ?????? ???? ???? ?????????????????? ???? ?? ?????????? ?????????????????????? ?? ??????????????.</p>
            <p class=""text"" style=""margin-bottom: 2vh;"">???????????? ???????????????????????????????? ?????????? ?????????????????????? ?????? ???????????? ?????? ???????????????????????</p>
            <div class=""flex-box-horizontal"" style=""width: 50vw"">
                <button class=""button-purple"" style=""width: 15vw"" onclick=""ShowRegistrationForm()"">????????????????????????????????</button>
                <button class=""button-purple"" style=""width: 15vw"" onclick=""ShowInputCodeForm()"">???????????? ??????</button>
                <a href=""/Account/SignOut""><button class=""button-purple"" style=""width: 15vw"">??????????</button></a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 26 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f0bcaaa4794094d8531358cd3da5574166c3b312501", async() => {
                WriteLiteral(@"
        <div id=""main"">
            <div class=""gradient-container"">
                <div class=""logo white"">
                    <svg style=""width: 4vh; height: 4vh"" viewBox=""0 0 30 30"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <g clip-path=""url(#clip0)"">
                            <path d=""M11.0714 0H2.5C1.11929 0 0 1.11929 0 2.5V11.0714C0 12.4521 1.11929 13.5714 2.5 13.5714H11.0714C12.4521 13.5714 13.5714 12.4521 13.5714 11.0714V2.5C13.5714 1.11929 12.4521 0 11.0714 0Z"" fill=""#FFFFFF"" />
                            <path d=""M27.5 0H18.9286C17.5479 0 16.4286 1.11929 16.4286 2.5V11.0714C16.4286 12.4521 17.5479 13.5714 18.9286 13.5714H27.5C28.8807 13.5714 30 12.4521 30 11.0714V2.5C30 1.11929 28.8807 0 27.5 0Z"" fill=""#FFFFFF"" />
                            <path d=""M27.5 16.4286H18.9286C17.5479 16.4286 16.4286 17.5479 16.4286 18.9286V27.5C16.4286 28.8807 17.5479 30 18.9286 30H27.5C28.8807 30 30 28.8807 30 27.5V18.9286C30 17.5479 28.8807 16.4286 27.5 16.4286Z"" fill=""#FFFF");
                WriteLiteral(@"FF"" />
                            <path d=""M11.0714 16.4286H2.5C1.11929 16.4286 0 17.5479 0 18.9286V27.5C0 28.8807 1.11929 30 2.5 30H11.0714C12.4521 30 13.5714 28.8807 13.5714 27.5V18.9286C13.5714 17.5479 12.4521 16.4286 11.0714 16.4286Z"" fill=""#FFFFFF"" />
                            <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M27.0615 4.99432C27.3615 4.60297 27.2874 4.04252 26.8961 3.74251C26.5047 3.4425 25.9443 3.51655 25.6443 3.9079L22.3054 8.26339L20.4655 6.42352C20.1168 6.07483 19.5515 6.07483 19.2028 6.42352C18.8541 6.7722 18.8541 7.33754 19.2028 7.68622L21.7282 10.2116C21.9862 10.4696 22.3628 10.5367 22.6825 10.4129C22.8624 10.3627 23.028 10.2559 23.1504 10.0963L27.0615 4.99432Z"" fill=""#3B026D"" />
                        </g>
                        <defs>
                            <clipPath id=""clip0"">
                                <rect width=""30"" height=""30"" fill=""white"" />
                            </clipPath>
                        </defs>
                    </svg>
        ");
                WriteLiteral("            <p class=\"logo-text white\">Repair Planner</p>\r\n                </div>\r\n                <div class=\"left-container\">\r\n                    ");
#nullable restore
#line 50 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("UserData"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div id=\"statistics-container\">\r\n                        ");
#nullable restore
#line 52 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Statistics"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""main-container"">
                <div class=""flex-box-vertical"">
                    <input id=""search-field"" type=""search"" placeholder=""??????????"" onkeyup=""if (event.key == 'Enter') Search()"">
                    <div class=""flex-box-horizontal"" style=""justify-content: space-between; margin-top: 2vh; width: 65vw"">
                        <div class=""flex-box-horizontal sections"" style=""width: 45vw"">
                            <h1 id=""all-section"" class=""active-section section-name"" onclick=""EnableSection('all')"">??????</h1>
                            <h1 id=""active-section"" class=""section-name"" onclick=""EnableSection('active')"">????????????????</h1>
                            <h1 id=""completed-section"" class=""section-name"" onclick=""EnableSection('completed')"">????????????????????????</h1>
                        </div>
                        <form action=""/Home/GetAddTask"" method=""post"" data-ajax=""true"" data-ajax-mode=""replac");
                WriteLiteral(@"e"" data-ajax-update=""#ajax-add-container"">
                            <a href=""#add-task-container"">
                                <button class=""button-purple"" type=""submit"" onclick=""ShowAddWindow()"">
                                    <svg viewBox=""0 0 25 25"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" class=""svg-plus"">
                                        <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M12.6923 0C13.8606 0 14.8077 1.11929 14.8077 2.5V22.5C14.8077 23.8807 13.8606 25 12.6923 25C11.524 25 10.5769 23.8807 10.5769 22.5V2.5C10.5769 1.11929 11.524 0 12.6923 0Z"" fill=""white"" />
                                        <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M0 12.6923C0 11.524 1.11929 10.5769 2.5 10.5769H22.5C23.8807 10.5769 25 11.524 25 12.6923C25 13.8606 23.8807 14.8077 22.5 14.8077H2.5C1.11929 14.8077 0 13.8606 0 12.6923Z"" fill=""white"" />
                                    </svg>
                                    ???????????????? ????????????
                                </bu");
                WriteLiteral(@"tton>
                            </a>
                        </form>
                    </div>
                    <div class=""tasks-container"" id=""tasks""></div>
                </div>
            </div>
        </div>
        <div id=""ajax-add-container""></div>
        <div id=""ajax-view-task""></div>
        <div id=""ajax-container""></div>
    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 85 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</html>");
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
