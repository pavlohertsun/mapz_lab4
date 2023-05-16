using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Lake
    {
        public int[,] matrix;
        public int size;
        public Lake(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }
    }
}
