using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sang
{
    internal class Artist : Stamp
    {
        public string ArtistName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            return 42;
        }

        public override string ToString()
        {
            return $"\nName: {ArtistName}\nCountry: {Country}\nDoB: {Birthday.ToString("yyyy-MM-dd")}\n";
        }
    }
}
