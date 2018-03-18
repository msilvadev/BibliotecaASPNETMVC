using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaASP.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [DisplayName("Nome do Livro")] //ira exibir como nome do livro na label 
        public string Nome { get; set; }

        [DisplayName("Total de páginas do livro")]
        public int TotalPaginas { get; set; }

        [DisplayName("Descrição do livro")]
        public string Descricao { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        public Categoria categoria { get; set; }

        public Autor autor { get; set; }

        public int CategoriaId { get; set; }

        public int AutorId { get; set; }
    }
}