using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class RawStockScoringTable
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public string SymbolE { get; set; }
        public double? CloseE { get; set; }
        public string SymbolI { get; set; }
        public double? CloseI { get; set; }
        public string SymbolP { get; set; }
        public double? CloseP { get; set; }
        public string SymbolT { get; set; }
        public double? CloseT { get; set; }
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
