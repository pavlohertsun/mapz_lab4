using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Hero
{
    public class AvailableState : State
    {
        public override bool checkState()
        {
            Console.WriteLine("You are enable to start fishing!");
            return true;
        }
    }
}
