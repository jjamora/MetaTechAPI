using MTC.Core.Common;

namespace MTC.Core.Models
{
    public class Pizza
    {
        public required string Id { get; set; }
        public required string PIzza_Type_Id { get; set; }
        public Pizza_Type? PIzza_Type { get; set; }
        public required string Name { get; set; }
        public SizeEnum Size { get; set; }
        public double Price { get; set; }
    }
}
