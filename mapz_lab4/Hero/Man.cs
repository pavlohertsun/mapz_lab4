using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Hero
{
    public class Man : Gender
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
            stamina = 100;
            skills = 15;
            expirience = 1;
            moneyAmount = 50;
            backpack = new Backpack();
            backpack.equipment.stick.chanceToCatch += 30;
        }
        public override void digWorms()
        {
            Thread.Sleep(20000);
            Console.WriteLine("Digging worms");
            backpack.equipment.wormsAmount += 5;
        }
    }
}
