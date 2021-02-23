using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class SymbolListTiingo
    {
        public long? Index { get; set; }
        public string Symbol { get; set; }
        public double? ProcessedTiingo { get; set; }
        public double? MissedTiingo { get; set; }
        public DateTime? LastfoundTiingo { get; set; }
        public string TiingoSymbols { get; set; }
        public string MasterSymbol { get; set; }
        public DateTime? Date { get; set; }
        public string Merge { get; set; }
    }
}
