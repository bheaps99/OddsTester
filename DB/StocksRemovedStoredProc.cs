using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class StocksRemovedStoredProc
    {
        public string Symbol { get; set; }
        public DateTime CurrentflagChangeDate { get; set; }
    }
}
