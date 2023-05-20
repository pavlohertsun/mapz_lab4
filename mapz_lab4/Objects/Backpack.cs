using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Backpack
    {
        public Equipment equipment;
        public int fishJ_Amount;
        public int fishQ_Amount;
        public int fishK_Amount;
        public int fishA_Amount;

        public Backpack() 
        { 
            equipment = new Equipment();
            fishA_Amount = 0;
            fishJ_Amount = 0;
            fishQ_Amount = 0;
            fishK_Amount = 0;
        }
    }
}
