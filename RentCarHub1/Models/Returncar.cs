﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarHub1.Models
{
    public partial class Returncar
    {
        public int Id { get; set; }
        public string Carno { get; set; }
        public int? Custid { get; set; }
        public DateTime? Date { get; set; }
        public int? Elsp { get; set; }
        public int? Fine { get; set; }
    }
}
