using System;

namespace EGSBD.Models
{
    public class OrderType
    {
        public string ColumnName { get; set; }
        public SortType SortType { get; set; }

        public override string ToString()
        {
            return $"{ColumnName.Trim()} {SortType}";
        }
    }

    [Flags]
    public enum SortType
    {
        asc = 0,
        desc = 1
    }
}
