#pragma checksum "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c0a9baa0c47d49f15e795cda6dc04a18a2b7f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Index), @"mvc.1.0.view", @"/Views/Livro/Index.cshtml")]
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
#line 1 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\_ViewImports.cshtml"
using BibliotecaF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\_ViewImports.cshtml"
using BibliotecaF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c0a9baa0c47d49f15e795cda6dc04a18a2b7f3", @"/Views/Livro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a392746c40b98bfed47afa821b09d55de45e60", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Livros Listados</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
 if (TempData["msg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
   Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Criando link para cadastrar o livro-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c0a9baa0c47d49f15e795cda6dc04a18a2b7f35590", async() => {
                WriteLiteral("Cadastrar Livro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!--Tabelinha com loop pra cada livro-->
<!--Vamos exibir as informações-->
<table class=""table table-striped table-dark"">
    <tr>
        <th>Código</th>
        <th>Autor</th>
        <th>Título</th>
        <th>Editora</th>
        <th>DT Publicação</th>
        <th>Tipo</th>
        <th>Condição</th>
        <th>Preço</th>
        <th></th>
    </tr>
");
#nullable restore
#line 32 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
     foreach (var liv in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Editora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.DataPublicacao.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
            Write(liv.Condicao?"Velho":"Novo");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
           Write(liv.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c0a9baa0c47d49f15e795cda6dc04a18a2b7f39487", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
                                         WriteLiteral(liv.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1198, "\"", 1235, 3);
            WriteAttributeValue("", 1208, "livroId.value", 1208, 13, true);
            WriteAttributeValue(" ", 1221, "=", 1222, 2, true);
#nullable restore
#line 45 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
WriteAttributeValue(" ", 1223, liv.Codigo, 1224, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n                    Excluir\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Felipe\Desktop\Nac-Enterprise\BibliotecaF\Views\Livro\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmarção</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Tem certeza da exclusão do Livro?
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c0a9baa0c47d49f15e795cda6dc04a18a2b7f313288", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""livroId"" />
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                    <button type=""submit"" class=""btn btn-primary"">Sim</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591