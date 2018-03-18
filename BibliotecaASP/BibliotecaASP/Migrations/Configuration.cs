namespace BibliotecaASP.Migrations
{
    using BibliotecaASP.DataContext;
    using BibliotecaASP.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BibliotecaASP.DataContext.BibliotecaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BibliotecaDB context)
        {
            context.Categorias.AddOrUpdate(c => c.Nome, 
                new Categoria { Nome = "Ficcao"},
                new Categoria { Nome = "Outros"}
            );

            context.Autores.AddOrUpdate(l => l.Nome,
                new Autor { Nome = "J.K. Rowling" }, 
                new Autor { Nome = "Autor Inicial" }
            );
        }
    }
}
