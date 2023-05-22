using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Fishes
{
    public class Fish
    {
        public string name;
        public int cost;
        public int index1;
        public int index2;
        public int randomIndex()
        {
            Random rand = new Random(); 
            int value = rand.Next(0, 100);
            return value;
        }
    }
}
