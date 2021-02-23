using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class ReferenceSecurity
    {
        public string Symbol1 { get; set; }
        public string Symbol2 { get; set; }
        public double? CorrCoeff { get; set; }
        public bool? IsEtf { get; set; }
    }
}
