using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class SymbolListIqfeed
    {
        public long? Index { get; set; }
        public string Symbol { get; set; }
        public double? ProcessedIqfeed { get; set; }
        public double? MissedIqfeed { get; set; }
        public DateTime? LastfoundIqfeed { get; set; }
        public string IqfeedSymbols { get; set; }
        public string MasterSymbol { get; set; }
        public string Date { get; set; }
        public string Merge { get; set; }
    }
}
