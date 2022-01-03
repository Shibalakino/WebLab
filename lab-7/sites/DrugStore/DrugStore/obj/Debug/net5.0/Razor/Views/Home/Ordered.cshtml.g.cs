#pragma checksum "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7178a6f76d2b9928db9eba2d3863d7ebd63de0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ordered), @"mvc.1.0.view", @"/Views/Home/Ordered.cshtml")]
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
#line 1 "C:\Repos\DrugStore\DrugStore\Views\_ViewImports.cshtml"
using DrugStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\DrugStore\DrugStore\Views\_ViewImports.cshtml"
using DrugStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7178a6f76d2b9928db9eba2d3863d7ebd63de0b", @"/Views/Home/Ordered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2673840b6fdbf8331baca8a9016bdf5951f40a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ordered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DrugStore.Models.Drug>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
  
    ViewData["Title"] = "Ordered drugs";
    List<(string ClientName, string Address, string ContactPhone, string DrugTitle)> ordersData
        = (List<(string, string, string, string)>)ViewData["OrdersData"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7178a6f76d2b9928db9eba2d3863d7ebd63de0b3549", async() => {
                WriteLiteral("\r\n    <title>Ducks do drugs</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7178a6f76d2b9928db9eba2d3863d7ebd63de0b4552", async() => {
                WriteLiteral("\r\n    <h3>Ordered Drugs</h3>\r\n    <table style=\"width:80%\">\r\n        <tr>\r\n            <td>Client name</td>\r\n            <td>Address</td>\r\n            <td>Contact phone</td>\r\n            <td>Drug</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
         foreach (var orderData in ordersData)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
               Write(orderData.ClientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
               Write(orderData.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
               Write(orderData.ContactPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
               Write(orderData.DrugTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Repos\DrugStore\DrugStore\Views\Home\Ordered.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DrugStore.Models.Drug>> Html { get; private set; }
    }
}
#pragma warning restore 1591