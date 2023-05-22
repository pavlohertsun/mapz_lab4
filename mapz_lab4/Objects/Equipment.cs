using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Equipment
    {
        public int wormsAmount { get; set; }
        public int baitAmount { get; set; }
        public Stick stick;
        public Equipment() 
        { 
            wormsAmount = 5;
            baitAmount = 1;
            stick = new Stick();
        }
        public bool subWorm()
        {
            if((wormsAmount - 1) == 0) 
            {
                notify();
                wormsAmount--;
                return true;
            }
            else
            {
                wormsAmount--;
                return false;
            }
        }
        public void notify()
        {
            GlobalVariables.notify = true;
        }
    }
}
