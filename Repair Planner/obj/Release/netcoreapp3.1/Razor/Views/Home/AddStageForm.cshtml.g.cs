#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05cfea7c6dbbe0fb3412242dbb25fb5536ef552a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddStageForm), @"mvc.1.0.view", @"/Views/Home/AddStageForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cfea7c6dbbe0fb3412242dbb25fb5536ef552a", @"/Views/Home/AddStageForm.cshtml")]
    public class Views_Home_AddStageForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <form");
            BeginWriteAttribute("action", " action=\"", 49, "\"", 116, 4);
            WriteAttributeValue("", 58, "/Home/AddStage?date=", 58, 20, true);
#nullable restore
#line 5 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml"
WriteAttributeValue("", 78, DateTime.Now.ToString(), 78, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 102, "&taskId=", 102, 8, true);
#nullable restore
#line 5 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml"
WriteAttributeValue("", 110, Model, 110, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" data-ajax=\"true\" data-ajax-mode=\"replace\" data-ajax-update=\"#stage-list\">\r\n        <div class=\"stage-flex-box add-stage-form\">\r\n            <div class=\"date-time\">\r\n                <h1 class=\"date\">");
#nullable restore
#line 8 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml"
                            Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"time\">");
#nullable restore
#line 9 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\AddStageForm.cshtml"
                           Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""mark"">
                <svg class=""circle-mark"" viewBox=""0 0 17 17"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""8.5"" cy=""8.5"" r=""8.5"" fill=""#7203BA"" />
                </svg>
            </div>
            <input required class=""stage-name"" placeholder=""Название"" name=""stageName"" style=""width:18vw;""/>
            <input class=""stage-cost stage-name"" placeholder=""Цена"" name=""stageCost""/>
            <button class=""button-purple add-progress-button submit-stage"" type=""submit"">
                <svg viewBox=""0 0 25 25"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" class=""plus-button-svg"">
                    <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M12.6923 0C13.8606 0 14.8077 1.11929 14.8077 2.5V22.5C14.8077 23.8807 13.8606 25 12.6923 25C11.524 25 10.5769 23.8807 10.5769 22.5V2.5C10.5769 1.11929 11.524 0 12.6923 0Z"" fill=""white"" />
                    <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M0 12.692");
            WriteLiteral(@"3C0 11.524 1.11929 10.5769 2.5 10.5769H22.5C23.8807 10.5769 25 11.524 25 12.6923C25 13.8606 23.8807 14.8077 22.5 14.8077H2.5C1.11929 14.8077 0 13.8606 0 12.6923Z"" fill=""white"" />
                </svg>
            </button>
        </div>
        <p class=""text form-note"">*Для завершения задачи назовите новый этап «Завершено»</p>        
    </form>
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
