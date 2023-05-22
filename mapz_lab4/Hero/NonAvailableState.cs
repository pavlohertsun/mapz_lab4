using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Hero
{
    public class NonAvailableState : State
    {
        public override bool showState()
        {
            Console.WriteLine("Your are too tired, you should have a sleep.");
            return false;
        }
    }
}
