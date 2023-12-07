namespace CustOrderManagement.Data.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PricedPerItem { get; set; }
        public int AverageCustomerRating { get; set; }
    }
} 
