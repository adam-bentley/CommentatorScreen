using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnCateg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Tree { get; set; }
        public int? Finish { get; set; }
        public bool? Dsf { get; set; }
        public int? Remotestart { get; set; }
        public decimal? Stagedtostart { get; set; }
        public int? Pstagedtostaged { get; set; }
        public bool? Stagelock { get; set; }
        public decimal? Index { get; set; }
        public int? Qualmode { get; set; }
        public int? Bump { get; set; }
        public bool? Teampoints { get; set; }
        public bool? SbSpeed { get; set; }
        public bool? SbRt { get; set; }
        public int? Breakout { get; set; }
        public int Pk { get; set; }
    }
}
