namespace CustOrderManagement.Api.Model
{
    public class OrderResponseDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal PricePaid { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
