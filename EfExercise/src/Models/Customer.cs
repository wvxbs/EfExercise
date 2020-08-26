using System;
using System.ComponentModel.DataAnnotations;

namespace EfExerciseASPNET.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Suname { get; set; }
    }
}