using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarHub1.Models
{
    public class RentailViewModel
    {
        public int Id { get; set; }
        public string Carid { get; set; }
        public int? Custid { get; set; }
        public int? Fee { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public string Available { get; set; }
    }
}
