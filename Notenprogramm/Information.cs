using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenprogramm
{
    public class TInformation
    {
        public DateTime time;
        public string information;

        public TInformation(string _information)
        {
            time = DateTime.Now;
            information = _information;
        }
    }
}
