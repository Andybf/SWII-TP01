using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace SWII_TP01.Controller {
    class Startup {

        public Startup() {
            IWebHost host = new WebHostBuilder()
                //.UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
        
        public void Configure(IApplicationBuilder app) {
            var builder = new RouteBuilder(app);
            builder.MapRoute("livro/nome", nome);
            builder.MapRoute("livro/toString", toString);
            builder.MapRoute("livro/getAuthorNames", getAuthorNames);
            builder.MapRoute("livro/ApresentarLivro/{nome}/{autor}", ApresentarLivro);

            var rotas = builder.Build();

            app.UseRouter(rotas);
            app.Run(Roteamento);
        }

        public Task Roteamento(HttpContext context) { 
            return context.Response.WriteAsync(context.Request.Path);
        }

        public Task nome(HttpContext context) {
            /*
            var _repo = new LivroRepositorioCSV();
            var conteudoArquivo = CarregaArquivoHTML("para-ler");

            foreach (var livro in _repo.ParaLer.Livros) {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            }
            conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

            return context.Response.WriteAsync(conteudoArquivo);
            */
            return null;
        }

        public Task toString(HttpContext context) {
            //var _repo = new LivroRepositorioCSV();
            //return context.Response.WriteAsync(_repo.Lendo.ToString());
            return null;
        }

        public Task getAuthorNames(HttpContext context) {
            //var _repo = new LivroRepositorioCSV();
            // return context.Response.WriteAsync(_repo.Lidos.ToString());
            return null;
        }

        public Task ApresentarLivro(HttpContext context) {
            Model.Author a = new Model.Author();
            var livro = new Model.Book(
                Convert.ToString(context.GetRouteValue("nome")),
                null,
                0
            );

           // var repo = new LivroRepositorioCSV();
            //repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com sucesso");

        }

    }
}
