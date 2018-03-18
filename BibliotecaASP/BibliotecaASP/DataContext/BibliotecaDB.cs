using BibliotecaASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BibliotecaASP.DataContext
{
    public class BibliotecaDB : DbContext
    {
        // o DbSet<> mapeia uma classe para uma tabela dentro de um banco de dados
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}