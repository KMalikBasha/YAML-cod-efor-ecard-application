namespace EshopApplication.Models.spModel
{

    //model to bind the result of spGetItemsByUserId stored procedure
    public class GetProductsFromCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
        public int ProductId { get; set; }
        public string imageURL { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
