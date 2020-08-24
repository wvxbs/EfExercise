using System;
using System.ComponentModel.DataAnnotations;

namespace EfExercise.src.Models
{
    class Rent
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime RentDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int BookId{ get; set; }
        public int ClientId { get; set; }
    }
}