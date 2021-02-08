using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Laba3
{
    class LinqXML: ISearch
    {
        List<Flights> find = null;
        XDocument document = new XDocument();
        public List<Flights> Search(Flights flight, string path)
        {
            document = XDocument.Load(@path);
            find = new List<Flights>();
            List<XElement> results = (from val in document.Descendants("flight")
                                      where (
                                      (flight.Price == null || flight.Price == val.Attribute("Price").Value) &&
                                      (flight.Departure == null || flight.Departure == val.Attribute("Departure").Value) &&
                                      (flight.Arrival == null || flight.Arrival == val.Attribute("Arrival").Value) &&
                                      (flight.Date == null || flight.Date == val.Attribute("Date").Value) &&
                                      (flight.Duration == null || flight.Duration == val.Attribute("Duration").Value) &&
                                      (flight.Airline == null || flight.Airline == val.Attribute("Airline").Value) &&
                                      (flight.IncludeLunch == null || flight.IncludeLunch == val.Attribute("IncludeLunch").Value) &&
                                      (flight.TourOperator == null || flight.TourOperator == val.Attribute("TourOperator").Value)
                                      )
                                      select val).ToList();
            foreach(XElement result in results)
            {
                Flights res = new Flights();
                res.Price = result.Attribute("Price").Value;
                res.Departure = result.Attribute("Departure").Value;
                res.Arrival = result.Attribute("Arrival").Value;
                res.Date = result.Attribute("Date").Value;
                res.Duration = result.Attribute("Duration").Value;
                res.Airline = result.Attribute("Airline").Value;
                res.IncludeLunch = result.Attribute("IncludeLunch").Value;
                res.TourOperator = result.Attribute("TourOperator").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
