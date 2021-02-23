using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class SymbolListPolygon
    {
        public long? Index { get; set; }
        public string Symbol { get; set; }
        public long? ProcessedPolygon { get; set; }
        public long? MissedPolygon { get; set; }
        public DateTime? LastfoundPolygon { get; set; }
        public string PolygonSymbols { get; set; }
        public string MasterSymbol { get; set; }
        public DateTime? Date { get; set; }
        public string Merge { get; set; }
    }
}
