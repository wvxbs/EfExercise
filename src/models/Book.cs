using System;
using System.ComponentModel.DataAnnotations;

namespace EfExercise.src.Models
{
    class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public bool isAvailable { get; set; }
    }
}