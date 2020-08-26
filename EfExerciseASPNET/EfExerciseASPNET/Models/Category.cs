using System;
using System.ComponentModel.DataAnnotations;

namespace EfExerciseASPNET.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}