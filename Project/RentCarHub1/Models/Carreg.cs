using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarHub1.Models
{
    public partial class Carreg
    {
        public int Id { get; set; }
        public string Carno { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Available { get; set; }
    }
}
