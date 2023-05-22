using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Stick
    {
        public int waist { get; set; }
        public int chanceToCatch;
        public bool isAvailable;
        public Stick()
        {
            waist = 10;
            chanceToCatch = 0;
        }
    }
}
