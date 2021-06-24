using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnQual
    {
        public int? Category { get; set; }
        public int? Qualrnd { get; set; }
        public string Racenum { get; set; }
        public decimal? Reaction { get; set; }
        public decimal? Index { get; set; }
        public decimal? Et { get; set; }
        public decimal? Speed { get; set; }
        public int Id { get; set; }
        public string Remarks { get; set; }
        public int? Runid { get; set; }
    }
}
