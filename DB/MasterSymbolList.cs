using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class MasterSymbolList
    {
        public int StageId { get; set; }
        public string Symbol { get; set; }
        public string Securityname { get; set; }
        public string Exchange { get; set; }
        public bool? Etf { get; set; }
        public bool? Etn { get; set; }
        public bool? Include { get; set; }
        public int? ProcessedEod { get; set; }
        public int? ProcessedIqfeed { get; set; }
        public int? ProcessedPolygon { get; set; }
        public int? ProcessedTiingo { get; set; }
        public int? MissedEod { get; set; }
        public int? MissedIqfeed { get; set; }
        public int? MissedPolygon { get; set; }
        public int? MissedTiingo { get; set; }
        public DateTime? LastfoundEod { get; set; }
        public DateTime? LastfoundIqfeed { get; set; }
        public DateTime? LastfoundPolygon { get; set; }
        public DateTime? LastfoundTiingo { get; set; }
        public int? Currentflag { get; set; }
        public int? Deletedflag { get; set; }
        public DateTime? Effectivetodate { get; set; }
        public DateTime? Effectivefromdate { get; set; }
        public bool? IsEtf { get; set; }
    }
}
