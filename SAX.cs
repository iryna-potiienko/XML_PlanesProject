using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Laba3
{
    class SAX: ISearch
    {
        private List<Flights> lastResult = null;
        public List<Flights> Search(Flights flight,string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Flights> result = new List<Flights>();
            Flights find = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "flight")
                        {
                            find = new Flights();
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "Price")
                                    find.Price = reader.Value;
                                if (reader.Name == "Departure")
                                    find.Departure = reader.Value;
                                if (reader.Name == "Arrival")
                                    find.Arrival = reader.Value;
                                if (reader.Name == "Date")
                                    find.Date = reader.Value;
                                if (reader.Name == "Duration")
                                    find.Duration = reader.Value;
                                if (reader.Name == "Airline")
                                    find.Airline = reader.Value;
                                if (reader.Name == "IncludeLunch")
                                    find.IncludeLunch = reader.Value;
                                if (reader.Name == "TourOperator")
                                    find.TourOperator = reader.Value;
                            }
                            result.Add(find);
                        }
                        break;
                }
            }
            lastResult = Filter(result,flight);
            return lastResult;
        }
        private List<Flights> Filter(List<Flights> allResults, Flights flight)
        {
            List<Flights> newResult = new List<Flights>();
            if (allResults != null)
            {
                foreach(Flights fl in allResults)
                {
                    if((flight.Price==fl.Price||flight.Price==null)&&
                            (flight.Departure==fl.Departure || flight.Departure==null)&&
                            (flight.Arrival == fl.Arrival || flight.Arrival == null) &&
                            (flight.Date == fl.Date || flight.Date == null) &&
                            (flight.Duration == fl.Duration || flight.Duration == null) &&
                            (flight.Airline == fl.Airline || flight.Airline == null) &&
                            (flight.IncludeLunch == fl.IncludeLunch || flight.IncludeLunch == null) &&
                            (flight.TourOperator == fl.TourOperator || flight.TourOperator == null)
                            )
                    {
                        newResult.Add(fl);
                    }
                }
            }
            return newResult;
        }
    }
}
