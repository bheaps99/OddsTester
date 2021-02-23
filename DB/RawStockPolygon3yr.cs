using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class RawStockPolygon3yr
    {
        public string MasterSymbol { get; set; }
        public DateTime Date { get; set; }
        public string Symbol { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public int? Volume { get; set; }
        public double? Tr { get; set; }
        public double? Vwap { get; set; }
        public bool? Adjusted { get; set; }
        public string ExtractedOn { get; set; }
    }
}
