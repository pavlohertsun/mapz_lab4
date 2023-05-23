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

        public virtual void sleep()
        {
            Console.WriteLine("Sleeping...");
            Thread.Sleep(30000);
            stamina = 100;
        }
        public void eat()
        {
            Console.WriteLine("Eating...");
            Thread.Sleep(5000);
            stamina += 30;
        }
        public virtual void digWorms()
        {
            Thread.Sleep(20000);
            Console.WriteLine("Digging worms");
            backpack.equipment.wormsAmount += 3;
        }

        public abstract void changeIndividualCharacteristics();
    }
}
