using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            
            //var builder = new RouteBuilder(app);
            //builder.MapRoute("{controller}/{action}", RoteamentoPadrao.TratamentoPadrao);

            //builder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            //builder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);
            //builder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            //builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
            //builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes);
            //builder.MapRoute("Cadstro/ExibirFormulario", CadastroLogica.ExibirFormulario);
            //builder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

            //var rotas = builder.Build();

            //app.UseRouter(rotas);
            //app.Run(Roteamento);
        }
        //public Task Roteamento(HttpContext context)
        //{
        //    var caminhosAtendidos = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer", LivrosParaLer},
        //        { "/Livros/Lendo", LivrosLendo},
        //        { "/Livros/Lidos", LivrosLidos}
        //    };

        //    if (caminhosAtendidos.ContainsKey(context.Request.Path))
        //    {
        //        var metodo = caminhosAtendidos[context.Request.Path];
        //        return metodo.Invoke(context);
        //    }

        //    context.Response.StatusCode = 404;
        //    return context.Response.WriteAsync("Caminho inexistente!");
        //}
    }
}