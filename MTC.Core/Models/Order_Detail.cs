namespace MTC.Core.Models
{
    public class Order_Detail
    {
        public required string Id { get; set; }
        public required string Order_Id { get; set; }
        public Order? Order { get; set; }
        public required string Pizza_Id { get; set; }
        public Pizza? Pizza { get; set; }
        public int Quantity { get; set; }
    }
}
