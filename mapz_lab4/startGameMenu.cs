using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    internal class startGameMenu
    {
        public void printTable()
        {
            Character hero = new Character();
            Console.WriteLine("Available locations : ");
            for(int i = 0; i < hero.expirience; i++)
            {
                Console.WriteLine("[" + (i + 1) + "] - " + LocationCreator.LocationsList[i].ToString());
            }
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Your starter character's charackteristicks : ");
            Console.WriteLine(hero.ToString());
            Console.WriteLine("Location : ");
            Console.WriteLine(LocationCreator.LocationsList[choice - 1].ToString());
            Game game = Game.getInstance();
            game.game(LocationCreator.LocationsList[choice - 1].size);
        }
    }
}
