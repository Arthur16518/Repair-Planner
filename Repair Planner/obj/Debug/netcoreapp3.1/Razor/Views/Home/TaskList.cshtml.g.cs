#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c2214ceb1799a2a300598349b3f41f4be07eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskList), @"mvc.1.0.view", @"/Views/Home/TaskList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c2214ceb1799a2a300598349b3f41f4be07eb0", @"/Views/Home/TaskList.cshtml")]
    public class Views_Home_TaskList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Repair_Planner.Data.Models.Task>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
 foreach (var task in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 121, "\"", 168, 2);
            WriteAttributeValue("", 129, "task", 129, 4, true);
#nullable restore
#line 7 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
WriteAttributeValue(" ", 133, task.isActive ? "":"not-active", 134, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 169, "\"", 199, 3);
            WriteAttributeValue("", 179, "ShowTask(\'", 179, 10, true);
#nullable restore
#line 7 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
WriteAttributeValue("", 189, task.id, 189, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 197, "\')", 197, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"flex-box-vertical flex-box-task\">\r\n            <div class=\"flex-box-horizontal task-label-container\">\r\n                <div class=\"equipment-pic\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54c2214ceb1799a2a300598349b3f41f4be07eb04444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 413, "~/Sources/svg/", 413, 14, true);
#nullable restore
#line 11 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
AddHtmlAttributeValue("", 427, task.equipmentType, 427, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 448, ".svg", 448, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <h1 class=\"task-label\">");
#nullable restore
#line 13 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
                                  Write(task.shortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n");
#nullable restore
#line 15 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
              
                int dateDiff = (DateTime.Now - task.dateOfRecieving).Days;
                string res = dateDiff.ToString();
                bool betTenAndTwenty = false;
                if (dateDiff >= 10 && dateDiff <= 20)
                    betTenAndTwenty = true;
                dateDiff %= 10;
                if (betTenAndTwenty)
                    res = res + " ????????";
                else if (dateDiff == 1)
                    res = res + " ????????";
                else if (dateDiff <= 4 && dateDiff != 0)
                    res = res + " ??????";
                else
                    res = res + " ????????";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text task-p\">????????????: ?????????????? ");
#nullable restore
#line 31 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
                                              Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text task-p\">?????????????????? ????????????????: ");
#nullable restore
#line 32 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
                                                  Write(await Component.InvokeAsync("LastActivity", task));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text task-p\">????????????: ");
#nullable restore
#line 33 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
                                      Write(await Component.InvokeAsync("ClientShortString", task));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\TaskList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Repair_Planner.Data.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
