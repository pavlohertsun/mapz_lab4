using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class startGameMenu
    {
        public Character hero;
        public startGameMenu()
        {
            hero = new Character();
        }
        public void printTable()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your starter character's charackteristicks : ");
                Console.WriteLine(hero.ToString());
                Console.WriteLine("DNow you can :?\n[F] - start fishing\t [S] - open storage\t [Q] - quit the qame");
                string chr = Console.ReadLine();
                if (chr == "F")
                {
                    Console.WriteLine("Available locations : ");
                    for (int i = 0; i < hero.expirience; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "] - " + LocationCreator.LocationsList[i].ToString());
                    }
                    int choice = int.Parse(Console.ReadLine());
                    Game game = Game.getInstance();
                    game.game(LocationCreator.LocationsList[choice - 1].size);
                }
                if (chr == "S")
                {
                    Storage storage = new Storage();
                    storage.openStorage(this, hero);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
