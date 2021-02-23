using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class MasterResultsTable
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public long? Volume { get; set; }
        public double? Tr { get; set; }
        public string RecommendedSource { get; set; }
        public string Bucket { get; set; }
        public bool? Flag { get; set; }
        public string FlagCriterion { get; set; }
        public string SymbolE { get; set; }
        public double? OpenE { get; set; }
        public double? HighE { get; set; }
        public double? LowE { get; set; }
        public double? CloseE { get; set; }
        public long? VolumeE { get; set; }
        public double? TrE { get; set; }
        public string SymbolI { get; set; }
        public double? OpenI { get; set; }
        public double? HighI { get; set; }
        public double? LowI { get; set; }
        public double? CloseI { get; set; }
        public long? VolumeI { get; set; }
        public double? TrI { get; set; }
        public string SymbolP { get; set; }
        public double? OpenP { get; set; }
        public double? HighP { get; set; }
        public double? LowP { get; set; }
        public double? CloseP { get; set; }
        public long? VolumeP { get; set; }
        public double? TrP { get; set; }
        public string SymbolT { get; set; }
        public double? OpenT { get; set; }
        public double? HighT { get; set; }
        public double? LowT { get; set; }
        public double? CloseT { get; set; }
        public long? VolumeT { get; set; }
        public double? TrT { get; set; }
        public int? ReliabilityE { get; set; }
        public int? ReliabilityI { get; set; }
        public int? ReliabilityP { get; set; }
        public int? ReliabilityT { get; set; }
        public bool? ChooseE { get; set; }
        public bool? ChooseI { get; set; }
        public bool? ChooseP { get; set; }
        public bool? ChooseT { get; set; }
        public bool? Match3E { get; set; }
        public bool? Match3I { get; set; }
        public bool? Match3P { get; set; }
        public bool? Match3T { get; set; }
        public bool? Match2E { get; set; }
        public bool? Match2I { get; set; }
        public bool? Match2P { get; set; }
        public bool? Match2T { get; set; }
        public bool? Match1E { get; set; }
        public bool? Match1I { get; set; }
        public bool? Match1P { get; set; }
        public bool? Match1T { get; set; }
        public bool? NomatchE { get; set; }
        public bool? NomatchI { get; set; }
        public bool? NomatchP { get; set; }
        public bool? NomatchT { get; set; }
        public bool? NovalueE { get; set; }
        public bool? NovalueI { get; set; }
        public bool? NovalueP { get; set; }
        public bool? NovalueT { get; set; }
        public double? ChngfromprevE { get; set; }
        public double? ChngfromprevI { get; set; }
        public double? ChngfromprevP { get; set; }
        public double? ChngfromprevT { get; set; }
        public double? ChngfromprevRef { get; set; }
        public bool? ChngprevE { get; set; }
        public bool? ChngprevI { get; set; }
        public bool? ChngprevP { get; set; }
        public bool? ChngprevT { get; set; }
        public double? Median { get; set; }
        public double? DifffrommedE { get; set; }
        public double? DifffrommedI { get; set; }
        public double? DifffrommedP { get; set; }
        public double? DifffrommedT { get; set; }
        public bool? Diff100E { get; set; }
        public bool? Diff100I { get; set; }
        public bool? Diff100P { get; set; }
        public bool? Diff100T { get; set; }
        public double? Minmaxrange { get; set; }
        public double? Minmaxrangespread { get; set; }
    }
}
