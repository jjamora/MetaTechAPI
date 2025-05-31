namespace MTC.Core.Models
{
    public class Order
    {
        public required string Id { get; set; }
        public required string Date { get; set; }
        public required string Time { get; set; }

        public IEnumerable<Order_Detail>? Details { get; set; }
    }
}
