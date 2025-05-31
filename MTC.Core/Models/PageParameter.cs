namespace MTC.Core.Models
{
    public class PageParameter
    {
        public int MaxPageSize { get; set; } = 50;
        public int PageSize { get; set; } = 25;
        public int PageCount { get; set; } = 1;
        public int PageNumber { get; set; } = 1;
    }
}
