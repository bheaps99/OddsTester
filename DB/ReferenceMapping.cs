using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class ReferenceMapping
    {
        public long? StageId { get; set; }
        public string Symbol { get; set; }
        public string ReferenceEtf { get; set; }
        public DateTime? Effectivefromdate { get; set; }
        public double? CorrCoeff { get; set; }
    }
}
