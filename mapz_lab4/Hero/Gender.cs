using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Hero
{
    public abstract class Gender
    {
        public double attentiveness { get; set; }
        public double stamina { get; set; }
        public double skills { get; set; }
        public int expirience { get; set; }
        public int moneyAmount { get; set; }
        public Backpack backpack { get; set; }
        public State state { get; set; }

        public abstract void sleep();

        public abstract void changeIndividualCharacteristics();
    }
}
