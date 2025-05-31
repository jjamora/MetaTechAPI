namespace MTC.Core.Models.DTO
{
    public class Order_DetailDTO
    {
        public string? Id { get; set; }
        public string? Order_Id { get; set; }
        public string? Pizza_Id { get; set; }
        public int Quantity { get; set; }
    }
}
