using System.Collections.Generic;

namespace EGSBD.Models
{
    public interface IFilter
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
        IEnumerable<OrderType> OrderBy { get; set; }
    }
}
