namespace MTC.Core.Models.DTO
{
    public class OrderDTO
    {
        public string? Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
