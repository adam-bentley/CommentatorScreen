using System;
using System.Collections.Generic;

#nullable disable

namespace CommentatorScreen.Models.DB
{
    public partial class RnRacer
    {
        public int? Category { get; set; }
        public string Racenum { get; set; }
        public DateTime? Date { get; set; }
        public bool? Registered { get; set; }
        public int? Class { get; set; }
        public string Driver { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Code { get; set; }
        public string Carname { get; set; }
        public string Cartype { get; set; }
        public string Engine { get; set; }
        public bool? Allowpoints { get; set; }
        public int? Points { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public int Id { get; set; }
    }
}
