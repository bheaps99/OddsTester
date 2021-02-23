using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class MasterStockDatum
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Tr { get; set; }
        public decimal? Close { get; set; }
        public long? Volume { get; set; }
        public string Source { get; set; }
        public int? SourceScore { get; set; }
        public string SourceBucket { get; set; }
        public bool? FlagSplitE { get; set; }
        public bool? FlagSplitT { get; set; }
        public bool? FlagDodMoveE { get; set; }
        public bool? FlagDodMoveI { get; set; }
        public bool? FlagDodMoveT { get; set; }
        public string ReferenceEtf { get; set; }
        public double? CorrCoeff { get; set; }
    }
}
