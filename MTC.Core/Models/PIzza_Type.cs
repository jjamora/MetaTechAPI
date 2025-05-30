namespace MTC.Core.Models
{
    public class Pizza_Type
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public Category? Category { get; set; }
        public required string CategoryId { get; set; }
        public string? Ingredients { get; set; }
    }
}
