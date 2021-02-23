using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class RawStockTiingo3yr
    {
        public string MasterSymbol { get; set; }
        public DateTime Date { get; set; }
        public string Symbol { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public long? Volume { get; set; }
        public double Tr { get; set; }
        public double AdjOpen { get; set; }
        public double AdjHigh { get; set; }
        public double AdjLow { get; set; }
        public double AdjClose { get; set; }
        public long? AdjVolume { get; set; }
        public double DivCash { get; set; }
        public double SplitFactor { get; set; }
        public string ExtractedOn { get; set; }
    }
}
