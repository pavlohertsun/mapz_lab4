using mapz_lab4.Hero;
using mapz_lab4.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Fasad
    {
        public void printTable()
        {
            while (true)
            {
                Console.WriteLine("Choose gender :\n[1] - for man\t [2] - for woman");
                int gender = int.Parse(Console.ReadLine());
                Gender hero;
                if (gender == 1)
                {
                    hero = new Man();
                }
                else
                {
                    hero = new Woman();
                }
                hero.changeIndividualCharacteristics();
                Level1Stick stick = new Level1Stick(hero.backpack.equipment.stick);
                Level2Stick upgradedStick = new Level2Stick(hero.backpack.equipment.stick);
                Console.Clear();
                Console.WriteLine("Your starter character's charackteristicks : ");
                Console.WriteLine(hero.ToString());
                Console.WriteLine("Now you can :\n[F] - start fishing\t [S] - open storage\t [R] - sleep\t [Q] - quit the qame");
                string chr = Console.ReadLine();
                if (chr == "F" || chr == "f")
                {
                    checkIfHeroCanFishing(hero);
                    bool canStart = hero.state.showState();
                    if (canStart)
                    {
                        Console.WriteLine("Available locations : ");
                        for (int i = 0; i < hero.expirience; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "] - " + LocationCreator.LocationsList[i].ToString());
                        }
                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Do you want to use a bait?\n[Y] - for yes\t [N] - for no.");
                        string choice2 = Console.ReadLine();
                        if (hero.backpack.equipment.wormsAmount > 0)
                        {
                            if (stick.isAvailable)
                            {
                                DefaultGame game = DefaultGame.getInstance();
                                if (choice2 == "Y" || choice2 == "y")
                                {
                                    ProxyGame game1 = new ProxyGame(game);
                                    game1.game(LocationCreator.LocationsList[choice - 1].size, hero, stick, true);
                                    hero.backpack.equipment.baitAmount--;
                                }
                                if (choice2 == "N" || choice2 == "n")
                                {
                                    game.game(LocationCreator.LocationsList[choice - 1].size, hero, stick, false);
                                }
                            }
                            if (upgradedStick.isAvailable)
                            {
                                DefaultGame game = DefaultGame.getInstance();
                                if (choice2 == "Y" || choice2 == "y")
                                {
                                    ProxyGame game1 = new ProxyGame(game);
                                    game1.game(LocationCreator.LocationsList[choice - 1].size, hero, upgradedStick, true);
                                    hero.backpack.equipment.baitAmount--;
                                }
                                if (choice2 == "N" || choice2 == "n")
                                {
                                    game.game(LocationCreator.LocationsList[choice - 1].size, hero, upgradedStick, false);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can not go fishing. You dont have enough worms");
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if (chr == "S" || chr == "s")
                {
                    Storage storage = new Storage();
                    storage.openStorage(this, hero, stick, upgradedStick);
                }
                if (chr == "R" || chr == "r")
                {
                    hero.sleep();
                }
                if (chr == "Q" || chr == "q")
                {
                    Environment.Exit(0);
                }
            }
        }
        public void checkIfHeroCanFishing(Gender hero)
        {
            if (hero.stamina > 50)
            {
                hero.state = new AvailableState();
            }
            else
            {
                hero.state = new NonAvailableState();
            }
        }

    }
}

