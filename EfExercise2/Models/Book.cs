using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfExercise2.Models
{
    public class Book
    {
        [Key]
        public int Id{ get; set; }
        public string Nome { get; set; }
        public Category Categoria{ get; set; }
        public string Autor { get; set; }
        public bool Ativo { get; set; }
    }
}
