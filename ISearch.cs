using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Laba3
{
    public interface ISearch
    {
        List<Flights> Search(Flights flight, string path);
    }
}
