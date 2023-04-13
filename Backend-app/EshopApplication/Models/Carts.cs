using Models;
using System.ComponentModel.DataAnnotations;

namespace EshopApplication.Models
{
    public class Carts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
