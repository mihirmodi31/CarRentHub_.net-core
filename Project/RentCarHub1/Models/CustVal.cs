using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarHub1.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class customer
    {
        public class customerMetaData
        {
            [DisplayName("Name")]
            public string cutname { get; set; }

            [DisplayName("Address")]
            public string address { get; set; }

            [DisplayName("Mobile")]
            public int? mobile { get; set; }
        }

    }
}
