using MTC.Core.Common;

namespace MTC.Core.Models.DTO
{
    public class PizzaDTO
    {
        public string? Id { get; }
        public string? PIzza_Type_Id { get; }
        public string? Name { get; }
        public SizeEnum Size { get; }
        public double Price { get; }
    }
}
