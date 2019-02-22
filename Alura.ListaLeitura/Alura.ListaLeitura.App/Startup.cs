using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            //Roteamento AspNet Core MVC:
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();

            //Roteamento do AspNet Core:
            //var routeBuilder = new RouteBuilder(app);
            //routeBuilder.MapRoute("Livros/ParaLer", Livros.LivrosParaLer);
            //routeBuilder.MapRoute("Livros/Lendo", Livros.LivrosLendo);
            //routeBuilder.MapRoute("Livros/Lidos", Livros.LivrosLidos);
            //routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", Cadastro.CadastroNovoLivro);
            //routeBuilder.MapRoute("Livros/Detalhes/{id:int}", Livros.ExibeDetalhes);
            //routeBuilder.MapRoute("Cadastro/NovoLivro", Cadastro.ExibeFormulario);
            //routeBuilder.MapRoute("Cadastro/Incluir", Cadastro.ProcessaFormulario);
            //var rotas = routeBuilder.Build();
        }
    }
}

