using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnTransact
    {
        public int Id { get; set; }
        public string Tablename { get; set; }
        public string Identifier { get; set; }
        public string Action { get; set; }
        public string Username { get; set; }
        public string Notes { get; set; }
    }
}
