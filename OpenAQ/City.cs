using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAQ
{
    public class City
    {
        public string city { get; set; }
        public string country { get; set; }
        public int location { get; set; }
        public int count { get; set; }

        public override string ToString()
        {
            return $"{city} {country} {location} {count}";

        }
    }
}
