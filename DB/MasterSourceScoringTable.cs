using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class MasterSourceScoringTable
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public decimal? Open { get; set; }
        public decimal? Close { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Tr { get; set; }
        public long? Volume { get; set; }
        public string Source { get; set; }
        public int? SourceScore { get; set; }
        public bool? SourceFlag { get; set; }
        public string SourceBucket { get; set; }
        public decimal? ClosePd2 { get; set; }
        public decimal? CloseE2 { get; set; }
        public decimal? CloseI2 { get; set; }
        public decimal? CloseT2 { get; set; }
        public decimal? ChngfromprevE { get; set; }
        public decimal? ChngfromprevI { get; set; }
        public decimal? ChngfromprevT { get; set; }
        public string ReferenceEtf { get; set; }
        public double? CorrCoeff { get; set; }
        public decimal? CloseRef { get; set; }
        public decimal? CloseprevRef { get; set; }
        public decimal? ChngfromprevRef { get; set; }
        public double? Min33 { get; set; }
        public double? Max33 { get; set; }
        public double? Min50 { get; set; }
        public double? Max50 { get; set; }
        public int? SourceTotalE { get; set; }
        public int? SourceTotalI { get; set; }
        public int? SourceTotalT { get; set; }
        public int? ChngprevE { get; set; }
        public int? ChngprevI { get; set; }
        public int? ChngprevT { get; set; }
        public int? Rr1E { get; set; }
        public int? Rr2E { get; set; }
        public int? Rr1I { get; set; }
        public int? Rr2I { get; set; }
        public int? Rr1T { get; set; }
        public int? Rr2T { get; set; }
        public int? ScoreMatch1E { get; set; }
        public int? ScoreMatch1I { get; set; }
        public int? ScoreMatch1T { get; set; }
        public bool? SigDiff { get; set; }
        public decimal? DodMoveE { get; set; }
        public decimal? DodMoveI { get; set; }
        public decimal? DodMoveT { get; set; }
        public bool? FlagDodMoveE { get; set; }
        public bool? FlagDodMoveI { get; set; }
        public bool? FlagDodMoveT { get; set; }
        public bool? FlagSplitE { get; set; }
        public bool? FlagSplitT { get; set; }
        public double? OpenE { get; set; }
        public double? CloseE { get; set; }
        public double? LowE { get; set; }
        public double? HighE { get; set; }
        public double? TrE { get; set; }
        public long? VolumeE { get; set; }
        public double? OpenT { get; set; }
        public double? CloseT { get; set; }
        public double? LowT { get; set; }
        public double? HighT { get; set; }
        public double? TrT { get; set; }
        public long? VolumeT { get; set; }
        public double? OpenI { get; set; }
        public double? CloseI { get; set; }
        public double? LowI { get; set; }
        public double? HighI { get; set; }
        public double? TrI { get; set; }
        public long? VolumeI { get; set; }
        public bool? NovalueE { get; set; }
        public bool? NovalueI { get; set; }
        public bool? NovalueT { get; set; }
        public bool? Match2E { get; set; }
        public bool? Match1E { get; set; }
        public bool? NomatchE { get; set; }
        public bool? Match2I { get; set; }
        public bool? Match1I { get; set; }
        public bool? NomatchI { get; set; }
        public bool? Match2T { get; set; }
        public bool? Match1T { get; set; }
        public bool? NomatchT { get; set; }
    }
}
