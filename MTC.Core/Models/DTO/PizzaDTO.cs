using MTC.Core.Common;

namespace MTC.Core.Models.DTO
{
    public class PizzaDTO
    {
        public string? Id { get; set; }
        public string? PIzza_Type_Id { get; set; }
        public string? Name { get; set; }
        public SizeEnum Size { get; set; }
        public double Price { get; set; }
    }
}
