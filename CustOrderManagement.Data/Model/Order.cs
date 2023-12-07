namespace CustOrderManagement.Data.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal PricePaid { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
