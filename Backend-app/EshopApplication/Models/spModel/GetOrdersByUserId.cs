using System.ComponentModel.DataAnnotations;

namespace EshopApplication.Models.spModel
{
    public class GetOrdersByUserId
    {
        [Key]
        public int OrderId { get; set; }
        public string ImageURL { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
