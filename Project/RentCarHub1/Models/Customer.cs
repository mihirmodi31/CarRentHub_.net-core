using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarHub1.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Cutname { get; set; }
        public string Address { get; set; }
        public int? Mobile { get; set; }
    }
}
