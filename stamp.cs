using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sang
{
    public abstract class Stamp
    {
        public string User { get; set; } = "Anonoymous";
        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
