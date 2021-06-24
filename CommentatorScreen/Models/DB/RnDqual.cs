using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnDqual
    {
        public uint Id { get; set; }
        public string Reason { get; set; }
        public string Dqindex { get; set; }
    }
}
