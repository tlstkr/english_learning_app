#pragma checksum "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8b8af7d8270a2485b3df6c41ecf664541a6368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeckDetail_Index), @"mvc.1.0.view", @"/Views/DeckDetail/Index.cshtml")]
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
#line 1 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\_ViewImports.cshtml"
using english_learning_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\_ViewImports.cshtml"
using english_learning_app.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\_ViewImports.cshtml"
using english_learning_app.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\_ViewImports.cshtml"
using english_learning_app.Services.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8b8af7d8270a2485b3df6c41ecf664541a6368", @"/Views/DeckDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"621cf65e488c88b69d2ec4ee51b3b07541ee75c0", @"/Views/_ViewImports.cshtml")]
    public class Views_DeckDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeckViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeckDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
 if (Model.TotalCards == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"deck-detail-header\">\r\n                <h1 class=\"deck-detail-header-deckname\">");
#nullable restore
#line 8 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p>У цьому уроці поки що немає слів!</p>\r\n                <div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 332, "\'", 400, 1);
#nullable restore
#line 11 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
WriteAttributeValue("", 339, Url.Action("AddNewCard","DeckDetail", new { id = Model.Id }), 339, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link add-new-card-link\">Додати слово</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"deck-detail-header\">\r\n                <h1 class=\"deck-detail-header-deckname\">");
#nullable restore
#line 22 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div>");
#nullable restore
#line 23 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                 Write($"кількість слів у цьому уроці: {Model.TotalCards}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"start-quiz-container\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 873, "\'", 929, 1);
#nullable restore
#line 25 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
WriteAttributeValue("", 880, Url.Action("Index","Quiz",new { id = Model.Id }), 880, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary start-quiz-button"">Розпочати Тестування</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""row mt-5"">
        <div class=""col-12"">
            <div class=""card-detail-header"">
                <h2>Cards</h2>
                <div class=""add-new-card-container"">
                    <a");
            BeginWriteAttribute("href", " href=\'", 1283, "\'", 1351, 1);
#nullable restore
#line 35 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
WriteAttributeValue("", 1290, Url.Action("AddNewCard","DeckDetail", new { id = Model.Id }), 1290, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link pl-0\">додати ще одне слово</a>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                 foreach (Card card in Model.Cards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-text\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                           Write(card.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8b8af7d8270a2485b3df6c41ecf664541a63689524", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-link delete-card-button\">Видалити</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-deckId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-deckId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["deckId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                                                                                                                         WriteLiteral(card.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["cardId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cardId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["cardId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\Nata\source\repos\flashcards\web_english_learning_app\web_english_learning_app\Views\DeckDetail\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeckViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
