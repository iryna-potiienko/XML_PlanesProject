using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Laba3
{
    class DOM : ISearch
    {
        public List<Flights> Search(Flights flight, string path)
        {
            List<Flights> result = new List<Flights>();
            XmlDocument document = new XmlDocument();
            document.Load(@path);

            XmlNode node = document.DocumentElement;
            foreach(XmlNode nod in node.ChildNodes)
            {
                string Price = "";
                string Departure = "";
                string Arrival = "";
                string Date = "";
                string Duration = "";
                string Airline = "";
                string IncLunch = "";
                string TourOper = "";

                foreach(XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name == "Price" && (attribute.Value == flight.Price || flight.Price == null))
                        Price = attribute.Value;
                    if (attribute.Name == "Departure" && (attribute.Value == flight.Departure || flight.Departure == null))
                        Departure = attribute.Value;
                    if (attribute.Name == "Arrival" && (attribute.Value == flight.Arrival || flight.Arrival == null))
                        Arrival = attribute.Value;
                    if (attribute.Name == "Date" && (attribute.Value == flight.Date || flight.Date == null))
                        Date = attribute.Value;
                    if (attribute.Name == "Duration" && (attribute.Value == flight.Duration || flight.Duration == null))
                        Duration = attribute.Value;
                    if (attribute.Name == "Airline" && (attribute.Value == flight.Airline || flight.Airline == null))
                        Airline = attribute.Value;
                    if (attribute.Name == "IncludeLunch" && (attribute.Value == flight.IncludeLunch || flight.IncludeLunch == null))
                        IncLunch = attribute.Value;
                    if (attribute.Name == "TourOperator" && (attribute.Value == flight.TourOperator || flight.TourOperator == null))
                        TourOper = attribute.Value;
                }
                if (Price != "" && Departure!= "" && Arrival != "" && Date!="" && Duration != "" && Airline != "" && IncLunch != "" && TourOper != "")
                {
                    Flights myFlight = new Flights();
                    myFlight.Price = Price;
                    myFlight.Departure = Departure;
                    myFlight.Arrival = Arrival;
                    myFlight.Date = Date;
                    myFlight.Duration = Duration;
                    myFlight.Airline = Airline;
                    myFlight.IncludeLunch = IncLunch;
                    myFlight.TourOperator = TourOper;
                    result.Add(myFlight);
                }
            }
            return result;
        }
    }
}
