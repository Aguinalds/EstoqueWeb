#pragma checksum "C:\Users\Pichau\source\repos\EstoqueWeb\EstoqueWeb\Views\Shared\_ConsultaCEP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe5e00d79ea4ed036610145084403db9e30678a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ConsultaCEP), @"mvc.1.0.view", @"/Views/Shared/_ConsultaCEP.cshtml")]
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
#line 1 "C:\Users\Pichau\source\repos\EstoqueWeb\EstoqueWeb\Views\_ViewImports.cshtml"
using EstoqueWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pichau\source\repos\EstoqueWeb\EstoqueWeb\Views\_ViewImports.cshtml"
using EstoqueWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pichau\source\repos\EstoqueWeb\EstoqueWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe5e00d79ea4ed036610145084403db9e30678a", @"/Views/Shared/_ConsultaCEP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8315ff2aad0e85afd4d9eb233094718c7f75bd05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ConsultaCEP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""
        integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

");
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(function () {

        function limpar_dados_cep() {
            //Limpa valores do formulário de cep.
            $(""#Logradouro"").val('');
            $(""#Bairro"").val('');
            $(""#Cidade"").val('');
            $(""#Estado"").val('');
            $(""#endereco"").text('Digite um CEP válido e aguarde.');
            //Mostra o ícone de inválido
            $(""#cep_none"").removeClass(""d-none"");
            $(""#cep_loading"").addClass(""d-none"");
            $(""#cep_checked"").addClass(""d-none"");
        }

        function consultar_cep() {
            //Nova variável ""cep"" somente com dígitos.
            var cep = $(""#CEP"").val().replace(/\D/g, '');
            //Verifica se campo cep possui valor informado.
            if (cep != """") {
                //Expressão regular para validar o CEP.
                var validacep = /^[0-9]{8}$/;
                //Valida o formato do CEP.
                if (validacep.test(cep)) {
       ");
            WriteLiteral(@"             //Mostra o ícone de carregamento
                    $(""#cep_none"").addClass(""d-none"");
                    $(""#cep_loading"").removeClass(""d-none"");
                    $(""#cep_checked"").addClass(""d-none"");
                    //Consulta o webservice viacep.com.br/
                    $.getJSON(""https://viacep.com.br/ws/"" + cep + ""/json/?callback=?"", function (dados) {
                        //Mostra o ícone de verificado
                        $(""#cep_none"").addClass(""d-none"");
                        $(""#cep_loading"").addClass(""d-none"");
                        $(""#cep_checked"").removeClass(""d-none"");
                        if (!(""erro"" in dados)) {
                            //Atualiza os campos com os valores da consulta.
                            $(""#Logradouro"").val(dados.logradouro);
                            $(""#Bairro"").val(dados.bairro);
                            $(""#Cidade"").val(dados.localidade);
                            $(""#Estado"").val(dados.uf);
       ");
            WriteLiteral(@"                     $(""#endereco"").text(dados.logradouro + "", "" +
                                dados.bairro + "", "" + dados.localidade + "", "" + dados.uf + ""."");
                        } //end if.
                        else {
                            //cep pesquisado não foi encontrado.
                            limpar_dados_cep();
                            $(""#endereco"").text(""Este CEP não foi encontrado."");
                        }
                    });
                } //end if.
                else {
                    //cep é inválido.
                    limpar_dados_cep();
                    $(""#endereco"").text(""Este CEP não é válido."");
                }
            } //end if.
            else {
                //cep sem valor, limpa formulário.
                limpar_dados_cep();
                $(""#endereco"").text(""Digite um CEP válido e aguarde."");
            }
        };

        //Quando o campo cep perde o foco.
        $(""#CEP"").blur(consultar_cep);
");
            WriteLiteral("        consultar_cep();\r\n    });\r\n</script>\r\n\r\n");
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
