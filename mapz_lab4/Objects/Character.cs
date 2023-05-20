﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Character
    {
        public double attentiveness { get; set; }
        public double stamina { get; set; }
        public double skills { get; set; }
        public int expirience { get; set; }
        public int moneyAmount { get; set; }
        public Backpack backpack { get; set; }
        public Character()
        {
            stamina = 100;
            skills = 5;
            expirience = 1;
            attentiveness = 10;
            moneyAmount = 50;
            backpack = new Backpack();
        }
        public override string ToString()
        {
            string str = "Money amount : " + moneyAmount + " .\n" + "Stamina : " + stamina + " , skills : " + skills + " , attentiveness : " + attentiveness + " , expirience : " + +expirience + " .";
            str += "\nWorms : " + backpack.equipment.wormsAmount + " , bait amount : " + backpack.equipment.baitAmount + " .";
            return str;
        }
    }
}
