using System;
using System.ComponentModel.DataAnnotations;

namespace EfExerciseASPNET.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public bool isAvailable { get; set; }
    }
}