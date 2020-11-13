using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAvtoProkat
{
    public class ZakazD
    {
        public int ZakazID { get; set; }

        public DateTime ZakazStart { get; set; }

        public DateTime ZakazEnd { get; set; }

        public bool? Check { get; set; }

        public int EmplID { get; set; }

        public int? AktVidachi { get; set; }

        public int? AktPriema { get; set; }

        public int ClientID { get; set; }

        public int CarID { get; set; }
    }
}
