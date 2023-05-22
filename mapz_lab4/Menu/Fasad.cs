using mapz_lab4.Game;
using mapz_lab4.Hero;
using mapz_lab4.Location;
using mapz_lab4.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Menu
{
    public class Fasad
    {
        public Man man;
        Level1Stick stick;
        Level2Stick upgradedStick;
        public Fasad()
        {
            man = new Man();
            stick = new Level1Stick(man.backpack.equipment.stick);
            upgradedStick = new Level2Stick(man.backpack.equipment.stick);
        }
        public void printTable()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your starter character's charackteristicks : ");
                Console.WriteLine(man.ToString());
                Console.WriteLine("Now you can :\n[F] - start fishing\t [S] - open storage\t [R] - sleep\t [Q] - quit the qame");
                string chr = Console.ReadLine();
                if (chr == "F" || chr == "f")
                {
                    Console.WriteLine("Available locations : ");
                    for (int i = 0; i < man.expirience; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "] - " + LocationCreator.LocationsList[i].ToString());
                    }
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Do you want to use a bait?\n[Y] - for yes\t [N] - for no.");
                    string choice2 = Console.ReadLine();
                    if (man.stamina > 0 || man.backpack.equipment.wormsAmount > 0)
                    {
                        if (stick.isAvailable)
                        {
                            DefaultGame game = DefaultGame.getInstance();
                            if (choice2 == "Y" || choice2 == "y")
                            {
                                ProxyGame game1 = new ProxyGame(game);
                                game1.game(LocationCreator.LocationsList[choice - 1].size, man, stick, true);
                                man.backpack.equipment.baitAmount--;
                            }
                            if (choice2 == "N" || choice2 == "n")
                            {
                                game.game(LocationCreator.LocationsList[choice - 1].size, man, stick, false);
                            }
                        }
                        if (upgradedStick.isAvailable)
                        {
                            DefaultGame game = DefaultGame.getInstance();
                            if (choice2 == "Y" || choice2 == "y")
                            {
                                ProxyGame game1 = new ProxyGame(game);
                                game1.game(LocationCreator.LocationsList[choice - 1].size, man, upgradedStick, true);
                            }
                            if (choice2 == "N" || choice2 == "n")
                            {
                                game.game(LocationCreator.LocationsList[choice - 1].size, man, upgradedStick, false);
                            }
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
                    storage.openStorage(this, man, stick, upgradedStick);
                }
                if (chr == "R" || chr == "r")
                {
                    Console.Clear();
                    Console.WriteLine("Sleeping...");
                    Thread.Sleep(30000);
                }
                if (chr == "Q" || chr == "q")
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}
