#pragma checksum "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfadd98455ab223ea49a6b96121ca6ed0682a36e"
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
#nullable restore
#line 1 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
using GameShop.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfadd98455ab223ea49a6b96121ca6ed0682a36e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e4f2d1382b70432e23cf03130c3870902af444", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index/Shop/AllGames"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Home Page";

    var categories = (List<Category>)ViewData["Categories"];
    List<(string Title, List<Category> Categories, string Description, double Price, string ImageLink)> games
        = (List<(string, List<Category>, string, double, string)>)ViewData["Games"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<sidebar>\r\n");
#nullable restore
#line 15 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
      
        string routeUrlWithoutLastPart = "";
        string[] subs = Url.RouteUrl(ViewContext.RouteData.Values).Split('/');
        for (int i = 1; i < subs.Length - 1; i++)
        {
            routeUrlWithoutLastPart += "/" + subs[i];
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
     if (SignInManager.IsSignedIn(User)
    && Url.RouteUrl(ViewContext.RouteData.Values) != "/Home/Index"
    && routeUrlWithoutLastPart != "/Home/Index/Shop"
   )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadd98455ab223ea49a6b96121ca6ed0682a36e6350", async() => {
                WriteLiteral("Всі ігри ");
#nullable restore
#line 28 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                                           Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1001, "~/Home/Index/", 1001, 13, true);
#nullable restore
#line 28 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1014, UserManager.GetUserName(User), 1014, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1044, "/AllGames", 1044, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadd98455ab223ea49a6b96121ca6ed0682a36e8475", async() => {
#nullable restore
#line 31 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                                       Write(cat.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1174, "~/Home/Index/", 1174, 13, true);
#nullable restore
#line 31 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1187, UserManager.GetUserName(User), 1187, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1217, "/", 1217, 1, true);
#nullable restore
#line 31 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1218, cat.Name, 1218, 9, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadd98455ab223ea49a6b96121ca6ed0682a36e10872", async() => {
                WriteLiteral("Всі ігри");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadd98455ab223ea49a6b96121ca6ed0682a36e12196", async() => {
#nullable restore
#line 39 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                             Write(cat.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1412, "~/Home/Index/Shop/", 1412, 18, true);
#nullable restore
#line 39 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1430, cat.Name, 1430, 9, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</sidebar>\r\n<div class=\"game-cards-layout container\">\r\n    <div class=\"row row-cols-4\">\r\n");
#nullable restore
#line 45 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
         foreach (var game in games)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col game-card-container\">\r\n                <div class=\"game-card card h-100\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1739, "\"", 1760, 1);
#nullable restore
#line 49 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1745, game.ImageLink, 1745, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1782, "\"", 1805, 2);
#nullable restore
#line 49 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1788, game.Title, 1788, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1799, "image", 1800, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"title-category-buybutton\">\r\n                            <div class=\"title-category\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 53 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                  Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h6 class=\"card-subtitle mb-2 text-muted\">\r\n");
#nullable restore
#line 55 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                     foreach (var cat in game.Categories)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                         Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                               
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </h6>\r\n                            </div>\r\n");
#nullable restore
#line 61 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                             if (SignInManager.IsSignedIn(User))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadd98455ab223ea49a6b96121ca6ed0682a36e17310", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2666, "\"", 2685, 1);
#nullable restore
#line 64 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 2674, game.Title, 2674, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"gameTitle\" />\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2764, "\"", 2802, 1);
#nullable restore
#line 65 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 2772, UserManager.GetUserName(User), 2772, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"userName\" />\r\n                                    <button type=\"submit\" class=\"buybutton\">\r\n");
#nullable restore
#line 67 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                         if (game.Price == 0)
                                        {
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("Free");
#nullable restore
#line 69 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                             
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                             Write(game.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("₴");
#nullable restore
#line 73 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                                     
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"submit\">\r\n");
#nullable restore
#line 81 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                     if (game.Price == 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("Free");
#nullable restore
#line 83 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                         
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                         Write(game.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₴");
#nullable restore
#line 87 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                                                 
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </button>\r\n");
#nullable restore
#line 90 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 92 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
                                        Write(game.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 98 "C:\Repos\WebLab\lab-8\site\GameShop\GameShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<GameShopUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<GameShopUser> SignInManager { get; private set; }
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
