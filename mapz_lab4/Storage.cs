using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Storage
    {
        public List<string> Goods;
        public List<int> Costs;
        public Storage() 
        { 
            Goods = new List<string>()
            {
                "Bait",
                "Worm",
                "Renew stick"
            };
            Costs = new List<int>()
            {
                5,
                3,
                10
            };
        }
    }
}
