using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class UpdateChngfromprevRef
    {
        public string Symbol { get; set; }
        public DateTime? Date { get; set; }
        public string SymbolE { get; set; }
        public double? CloseE { get; set; }
        public string SymbolI { get; set; }
        public double? CloseI { get; set; }
        public string SymbolP { get; set; }
        public double? CloseP { get; set; }
        public string SymbolT { get; set; }
        public double? CloseT { get; set; }
        public double? ChngfromprevE { get; set; }
        public double? ChngfromprevI { get; set; }
        public double? ChngfromprevP { get; set; }
        public double? ChngfromprevT { get; set; }
        public double? ChngfromprevRef { get; set; }
    }
}
