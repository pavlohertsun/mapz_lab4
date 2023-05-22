using mapz_lab4.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Fasad
    {
        public Character hero;
        Level1Stick stick;
        Level2Stick upgradedStick;
        public Fasad()
        {
            hero = new Character();
            stick = new Level1Stick(hero.backpack.equipment.stick);
            upgradedStick = new Level2Stick(hero.backpack.equipment.stick);
        }
        public void printTable()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your starter character's charackteristicks : ");
                Console.WriteLine(hero.ToString());
                Console.WriteLine("Now you can :\n[F] - start fishing\t [S] - open storage\t [R] - sleep\t [Q] - quit the qame");
                string chr = Console.ReadLine();
                if (chr == "F" || chr == "f")
                {
                    Console.WriteLine("Available locations : ");
                    for (int i = 0; i < hero.expirience; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "] - " + LocationCreator.LocationsList[i].ToString());
                    }
                    int choice = int.Parse(Console.ReadLine());
                    if (hero.stamina > 0 || hero.backpack.equipment.wormsAmount > 0)
                    {
                        if (stick.isAvailable)
                        {
                            DefaultGame game = DefaultGame.getInstance();
                            //game.game(LocationCreator.LocationsList[choice - 1].size, hero, stick, false);
                            ProxyGame game1 = new ProxyGame(game);
                            game1.game(LocationCreator.LocationsList[choice - 1].size, hero, stick, true);
                        }
                        if (upgradedStick.isAvailable)
                        {
                            //DefaultGame game = DefaultGame.getInstance();
                            //game.game(LocationCreator.LocationsList[choice - 1].size, hero, upgradedStick, false);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can not go fishing.\nYou have no worms or too tired!");
                        Thread.Sleep(3000);
                    }
                }
                if (chr == "S" || chr == "s")
                {
                    Storage storage = new Storage();
                    storage.openStorage(this, hero, stick, upgradedStick);
                }
                if (chr == "R" || chr == "r")
                {
                    Console.Clear();
                    Console.WriteLine("Sleeping...");
                    Thread.Sleep(30000);
                    hero.stamina = 100;
                }
                if (chr == "Q" || chr == "q") 
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
