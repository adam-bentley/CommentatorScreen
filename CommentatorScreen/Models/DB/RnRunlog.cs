using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnRunlog
    {
        public int Runid { get; set; }
        public DateTime? Time { get; set; }
        public int? Category { get; set; }
        public string Mode { get; set; }
        public bool Lane { get; set; }
        public string Racenum { get; set; }
        public decimal? Index { get; set; }
        public decimal? Reaction { get; set; }
        public decimal? Et60 { get; set; }
        public decimal? Et330 { get; set; }
        public decimal? Et594 { get; set; }
        public decimal? Et660 { get; set; }
        public decimal? Speed660 { get; set; }
        public decimal? Et1000 { get; set; }
        public decimal? Speed1000 { get; set; }
        public decimal? Et1320 { get; set; }
        public decimal? Speed1320 { get; set; }
        public string Result { get; set; }
        public string Remarks { get; set; }
        public decimal? Diff { get; set; }
    }
}
