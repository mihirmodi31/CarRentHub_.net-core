using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarHub1.Models
{
    public partial class Rentail
    {
        public int Id { get; set; }
        public string Carid { get; set; }
        public int? Custid { get; set; }
        public int? Fee { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
