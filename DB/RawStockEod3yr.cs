using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class RawStockEod3yr
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public long? Volume { get; set; }
        public double? Tr { get; set; }
        public DateTime? ExtractedOn { get; set; }
    }
}
