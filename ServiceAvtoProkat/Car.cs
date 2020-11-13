using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAvtoProkat
{
    public class CarD
    {
        public int CarID { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int CarMileage { get; set; }
        public int Year { get; set; }
        public int CarPriseDay { get; set; }

        public int Zalog { get; set; }

        public bool? CarAbroad { get; set; }

        public bool? Child { get; set; }

        public string Nomer { get; set; }
        public string CarVinKuzov { get; set; }
        public string City { get; set; }

    }
}
