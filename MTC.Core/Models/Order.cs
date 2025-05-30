namespace MTC.Core.Models
{
    public class Order
    {
        public required string Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }

        public IEnumerable<Order_Detail>? Details { get; set; }
    }
}
