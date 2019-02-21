using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Alura.ListaLeitura.App.VIEW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Controller
{
    public class CadastroController
    {
        public static Task ProcessaFormulario(HttpContext context)
        {
            var livro = new Livro
            {
                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First(),
            };
            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);
            return context.Response.WriteAsync("Livro incluído com sucesso");
        }
        public static Task ExibeFormulario(HttpContext context)
        {
            var html = HTMLUtils.CarregaArquivoHTML("formulario");
            return context.Response.WriteAsync(html);
        }
        
        public string Incluir(Livro livro)
        {
            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);
            return "Livro incluído com sucesso";
        }

    }
}
