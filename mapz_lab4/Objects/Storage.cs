using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Storage
    {
        public List<string> Goods;
        public List<int> Costs;
        public Storage() 
        { 
            Goods = new List<string>()
            {
                "Bait",
                "Worm",
                "Renew stick"
            };
            Costs = new List<int>()
            {
                5,
                3,
                7
            };
        }
        public void openStorage(startGameMenu str, Character hero)
        {
            Console.Clear();
            Console.WriteLine("Hi there. Here you can buy or sell smth");
            while (true)
            {
                string choice = mainStorageText();
                if (choice == "B")
                {
                    buyingFunction(hero);
                }
                if (choice == "S")
                {
                    sellFunction(hero);
                }
                if (choice == "Q")
                {
                    break;
                }
            }
        }
        public string mainStorageText()
        {
            Console.WriteLine("You can buy : ");
            for (int i = 0; i < Goods.Count; i++)
            {
                Console.WriteLine(Goods[i] + " - " + Costs[i] + " coins.");
            }
            Console.WriteLine("Or sell fishes: ");
            Console.WriteLine("J - 3 coins.");
            Console.WriteLine("Q - 5 coins.");
            Console.WriteLine("K - 7 coins.");
            Console.WriteLine("A - 10 coins.");
            Console.WriteLine("[B] - to buy\t [S] - to sell\t [Q] - to quit storage");
            string choice = Console.ReadLine();
            return choice;
        }
        public void buyingFunction(Character hero)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your amounts : ");
                Console.WriteLine("Bait : " + hero.backpack.equipment.baitAmount);
                Console.WriteLine("Worms : " + hero.backpack.equipment.wormsAmount);
                Console.WriteLine("Stick waist : " + hero.backpack.equipment.stick.waist);
                Console.WriteLine("Options : ");
                for (int i = 0; i < Goods.Count; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] - " + Goods[i] + " - " + Costs[i] + " coins.");
                }
                Console.WriteLine("[0] - quit buying");
                Console.WriteLine("What do you want to buy : ");
                int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    bool answer = checkIfEnoughMoney(Costs[0], hero);
                    if (answer)
                    {
                        hero.moneyAmount -= Costs[0];
                        hero.backpack.equipment.baitAmount += 1;
                    }
                    else
                    {
                        Console.Clear ();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 2)
                {
                    bool answer = checkIfEnoughMoney(Costs[1], hero);
                    if (answer)
                    {
                        hero.moneyAmount -= Costs[1];
                        hero.backpack.equipment.wormsAmount += 1;
                    }
                    else
                    {
                        Console.Clear ();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 3)
                {
                    bool answer = checkIfEnoughMoney(Costs[2], hero);
                    if (answer)
                    {
                        hero.moneyAmount -= Costs[2];
                        hero.backpack.equipment.stick.waist = 10;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 0)
                {
                    break;
                }
            }
        }
        public void sellFunction(Character hero)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your amounts : ");
                Console.WriteLine("Bait : " + hero.backpack.equipment.baitAmount);
                Console.WriteLine("Worms : " + hero.backpack.equipment.wormsAmount);
                Console.WriteLine("Options to sell : ");
                Console.WriteLine("[1] - bait, you get 5 coins \t [2] - worm, you get 3 coins \t [0] - quit selling");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.equipment.baitAmount);
                    if (answer)
                    {
                        hero.backpack.equipment.baitAmount--;
                        hero.moneyAmount += Costs[0];
                    }
                    else
                    {
                        Console.Clear ();
                        Console.WriteLine("Not enough bait to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 2)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.equipment.wormsAmount);
                    if (answer)
                    {
                        hero.backpack.equipment.wormsAmount--;
                        hero.moneyAmount += Costs[1];
                    }
                    else
                    {
                        Console.Clear ();
                        Console.WriteLine("Not enough worms to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 0)
                {
                    break;
                }
            }
        }
        public bool checkIfEnoughMoney(int price, Character hero)
        {
            if(hero.moneyAmount > price)
            {
                return true;
            }
            return false;
        }
        public bool checkIfEnoughItem(int number)
        {
            if(number > 0)
            {
                return true;
            }
            return false;
        }
    }
}
