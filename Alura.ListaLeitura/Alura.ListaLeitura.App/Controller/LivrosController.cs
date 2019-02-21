using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Alura.ListaLeitura.App.VIEW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Controller

{
   public class LivrosController
    {
        private static string CarregaLista(IEnumerable<Livro> livros)
        {
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("lista");
            foreach (var livro in livros)
            {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li> {livro.Titulo} - {livro.Autor}</li> #NOVO-ITEM#");
            }
            return conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM", " ");
        }
        public static Task LivrosParaLer(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            var html = CarregaLista(_repo.ParaLer.Livros); 
            return context.Response.WriteAsync(html);
        }

        public static Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }
        public static Task LivrosLidos(HttpContext context)
        {
            var conteudoarquivo = HTMLUtils.CarregaArquivoHTML("lidos");
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(conteudoarquivo);
        }
        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
        public string Teste()
        {
            return "Nova funcionalidade implementada";
        }

    }
}
    