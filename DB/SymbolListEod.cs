using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class SymbolListEod
    {
        public long? Index { get; set; }
        public string Symbol { get; set; }
        public double? ProcessedEod { get; set; }
        public double? MissedEod { get; set; }
        public DateTime? LastfoundEod { get; set; }
        public DateTime? Date { get; set; }
        public string Merge { get; set; }
    }
}
