using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfExercise2.Models
{
    public class Rent
    {
        [Key]
        public int Id { get; set; }

        public Book Livro { get; set; }
        public Customer Cliente { get; set; }
        public DateTime Emprestado { get; set; }
        public DateTime PrevisaoDevolucao { get; set; }
        public DateTime Devolucao { get; set; }

    }
}