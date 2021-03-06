#pragma checksum "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d07d1c12dcc43922a729fa773c66d1c04fc3df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_StageList_StageList), @"mvc.1.0.view", @"/Views/Home/Components/StageList/StageList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07d1c12dcc43922a729fa773c66d1c04fc3df", @"/Views/Home/Components/StageList/StageList.cshtml")]
    public class Views_Home_Components_StageList_StageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Repair_Planner.Data.Models.Stage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
   bool isActive = true; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"task-label progress-label\">Прогресс</h1>\r\n");
#nullable restore
#line 7 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
 foreach (var stage in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"stage-flex-box\">\r\n    <div class=\"date-time\">\r\n        <h1 class=\"date\">");
#nullable restore
#line 11 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
                    Write(stage.date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"time\">");
#nullable restore
#line 12 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
                   Write(stage.date.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"mark\">\r\n        <svg class=\"circle-mark\" viewBox=\"0 0 17 17\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n            <circle cx=\"8.5\" cy=\"8.5\" r=\"8.5\" fill=\"#7203BA\" />\r\n        </svg>\r\n");
#nullable restore
#line 18 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
         if (stage.name != "Завершено")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <svg class=\"line-mark\" viewBox=\"0 0 7 80\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n                <rect width=\"7\" height=\"80\" rx=\"3.5\" fill=\"#7203BA\" />\r\n            </svg>\r\n");
#nullable restore
#line 23 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
        }
        else
        {
            isActive = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <svg class=\"line-mark finished\" viewBox=\"0 0 7 80\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n                <rect width=\"7\" height=\"80\" rx=\"3.5\" fill=\"#7203BA\" />\r\n            </svg>\r\n");
#nullable restore
#line 30 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n        <h1 class=\"stage-name\">");
#nullable restore
#line 33 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
                          Write(stage.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"text\" style=\"font-size: 2vh; text-align: left; margin-top: 0.5vh\">");
#nullable restore
#line 34 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
                                                                               Write(await Component.InvokeAsync("ShortUserData", stage.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 36 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
     if (stage.name != "Завершено" && stage.name != "Добавлено")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"stage-cost\">\r\n            ");
#nullable restore
#line 39 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
        Write(stage.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" р.\r\n        </div>\r\n");
#nullable restore
#line 41 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
    }    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 43 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"add-stage-form\"></div>\r\n");
#nullable restore
#line 45 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
 if (isActive)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"button-purple add-progress-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1640, "\"", 1689, 3);
            WriteAttributeValue("", 1650, "ShowAddStageForm(", 1650, 17, true);
#nullable restore
#line 47 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
WriteAttributeValue("", 1667, Model.First().TaskId, 1667, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1688, ")", 1688, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <svg id=""plus-stage"" viewBox=""0 0 25 25"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" class=""plus-button-svg"">
            <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M12.6923 0C13.8606 0 14.8077 1.11929 14.8077 2.5V22.5C14.8077 23.8807 13.8606 25 12.6923 25C11.524 25 10.5769 23.8807 10.5769 22.5V2.5C10.5769 1.11929 11.524 0 12.6923 0Z"" fill=""white"" />
            <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M0 12.6923C0 11.524 1.11929 10.5769 2.5 10.5769H22.5C23.8807 10.5769 25 11.524 25 12.6923C25 13.8606 23.8807 14.8077 22.5 14.8077H2.5C1.11929 14.8077 0 13.8606 0 12.6923Z"" fill=""white"" />
        </svg>
    </button>
");
#nullable restore
#line 53 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 style=\"text-align: right; padding-top: 2vh;\">Итого: <v class=\"light-purple\">");
#nullable restore
#line 56 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
                                                                               Write(await Component.InvokeAsync("TotalSum", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(" р.</v></h1>\r\n");
#nullable restore
#line 57 "D:\MRC\Repair Planner\Repair Planner\Repair Planner\Views\Home\Components\StageList\StageList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Repair_Planner.Data.Models.Stage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
