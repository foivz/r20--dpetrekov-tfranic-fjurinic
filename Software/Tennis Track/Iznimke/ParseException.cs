using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Track.Iznimke
{
    public class ParseException : ApplicationException
    {
        public string Poruka { get; set; } = "Unesene vrijednosti nisu cijeli brojevi";

        /*public ParseException(string poruka)
        {
            Poruka = poruka;
        }*/
    }
}
