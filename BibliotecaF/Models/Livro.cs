using BibliotecaF.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaF.Models
{
    public class Livro
    {
        [HiddenInput]
        public int Codigo { get;  set; }

        [Display(Name = "Autor do Livro")]
        public string Autor { get; set; }

        [Display(Name = "Título do Livro")]
        public string Titulo { get; set; }

        [Display(Name = "Editora do Livro")]
        public string   Editora { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Publicação")]
        public DateTime DataPublicacao { get; set; }

        [Display(Name = "Tipo de Livro:")]
        public Tipo Tipo { get; set; }


        [Display(Name = "Livro velho")]
        public  Boolean Condicao  { get; set; }

        [Display(Name ="Preço do Livro")]
        public decimal Preco { get; set; }
        
    }
}
