using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnTrackinfo
    {
        public string Trackname { get; set; }
        public string Eventname { get; set; }
        public string Leftlane { get; set; }
        public string Rightlane { get; set; }
    }
}
