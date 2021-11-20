using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarHub1.Models
{
    [MetadataType(typeof(carregMetaData))]
    public partial class carreg
    {
        public class carregMetaData
        {
            [DisplayName("CarNo")]
            public string carno { get; set; }

            [DisplayName("Company")]
            public string make { get; set; }

            [DisplayName("Model")]
            public string model { get; set; }

            [DisplayName("Avalability")]
            public string available { get; set; }
        }
    }
}
