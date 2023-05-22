using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Location.Location
{
    public class Lake
    {
        public int[,] matrix;
        public Location location;
        public Lake(Location location)
        {
            this.location = location;
            matrix = new int[this.location.size, this.location.size];
        }
    }
}
