using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Hero
{
    public class Woman : Gender
    {
        public override string ToString()
        {
            string str = "Money amount : " + moneyAmount + " .\n" + "Stamina : " + stamina + " , skills : " + (int)skills + " , attentiveness : " + (int)attentiveness + " , expirience : " + expirience + " .";
            str += "\nWorms : " + backpack.equipment.wormsAmount + " , bait amount : " + backpack.equipment.baitAmount + " .";
            return str;
        }
        public override void changeIndividualCharacteristics()
        {
            attentiveness = 10;
            stamina = 150;
            skills = 10;
            expirience = 1;
            moneyAmount = 75;
            backpack = new Backpack();
            backpack.equipment.stick.chanceToCatch += 10;
        }
        public override void sleep()
        {
            Console.WriteLine("Sleeping...");
            Thread.Sleep(3000);
            stamina = 150;
        }
    }
}
