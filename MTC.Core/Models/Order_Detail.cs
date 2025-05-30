namespace MTC.Core.Models
{
    public class Order_Detail
    {
        public required string Id { get; set; }
        public required string Order_Id { get; set; }
        public required string Pizza_Id { get; set; }
        public int Quantity { get; set; }
    }
}
