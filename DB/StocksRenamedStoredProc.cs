using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class StocksRenamedStoredProc
    {
        public string OldSymbolName { get; set; }
        public string NewSymbolName { get; set; }
        public DateTime SymbolChangeDate { get; set; }
    }
}
