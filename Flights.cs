using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Laba3
{
    public class Flights
    {
        public Flights()
        { }

        public string Price { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Airline { get; set; }
        public string IncludeLunch { get; set; }
        public string TourOperator { get; set; }
        
        public ISearch MyFlight { get; set; }
        public List<Flights> Search(Flights flight, string path)
        {
            return MyFlight.Search(flight, path);
        }
    }
}
