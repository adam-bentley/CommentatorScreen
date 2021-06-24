using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnLadder
    {
        public int Category { get; set; }
        public int Elimrnd { get; set; }
        public int Pair { get; set; }
        public string Racenum1 { get; set; }
        public string Racenum2 { get; set; }
        public int Id { get; set; }
    }
}
