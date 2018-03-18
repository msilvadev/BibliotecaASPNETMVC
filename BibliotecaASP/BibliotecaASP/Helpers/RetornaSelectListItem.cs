using BibliotecaASP.DataContext;
using BibliotecaASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaASP.Helpers
{
    public class RetornaSelectListItem
    {
        private static BibliotecaDB db = new BibliotecaDB();

        public static List<SelectListItem> Autores()
        {
            //cria uma lista - e depois popula ela com registros vindos da tabela, que é acessada pelo db context
            List<Autor> lAutores = new List<Autor>();
            lAutores = db.Autores.ToList();
            //convert a lista lAutores em um SelectListItem, para que seja possivel listar na view
            List<SelectListItem> listaAutores = lAutores.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nome,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });
            return listaAutores;
        }

        public static List<SelectListItem> Categorias()
        {
            List<Categoria> lCategorias = new List<Categoria>();
            lCategorias = db.Categorias.ToList();

            List<SelectListItem> listaCategorias = lCategorias.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nome,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });
            return listaCategorias;
        }
    }
}