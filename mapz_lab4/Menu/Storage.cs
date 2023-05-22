using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mapz_lab4.Hero;

namespace mapz_lab4.Objects
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
                "Fish J",
                "Fish Q",
                "Fish K",
                "Fish A",
                "Renew stick"
            };
            Costs = new List<int>()
            {
                5,
                3,
                3,
                5,
                7,
                10,
                7
            };
        }
        public void openStorage(Fasad str, Gender hero, Stick stick1, Stick stick2)
        {
            Console.Clear();
            while (true)
            {
                string choice = mainStorageText();
                if (choice == "B" || choice == "b")
                {
                    buyingFunction(hero, stick1, stick2);
                }
                if (choice == "S" || choice == "s")
                {
                    sellFunction(hero);
                }
                if (choice == "Q" || choice == "q")
                {
                    break;
                }
            }
        }
        public string mainStorageText()
        {
            Console.WriteLine("Welcome to the storage!\nHere you can buy or sell smth : ");
            Console.WriteLine("[B] - to buy\t [S] - to sell\t [Q] - to quit storage");
            string choice = Console.ReadLine();
            return choice;
        }
        public void buyingFunction(Gender hero, Stick stick1, Stick stick2)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Buying menu : \n");
                showAmounts(hero);
                Console.WriteLine("Options : ");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] - " + Goods[i] + " - " + Costs[i] + " coins.");
                }
                Console.WriteLine("[3] - Renew stick - 7 coins.");
                Console.WriteLine("[4] - New location - 100 coins.");
                Console.WriteLine("[5] - Upgrade stick - 100 coins.");
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
                        Console.Clear();
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
                        Console.Clear();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 3)
                {
                    bool answer = checkIfEnoughMoney(Costs[6], hero);
                    if (answer)
                    {
                        hero.moneyAmount -= Costs[6];
                        hero.backpack.equipment.stick.waist = 10;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 4)
                {
                    bool answer = checkIfEnoughMoney(100, hero);
                    if (answer)
                    {
                        hero.moneyAmount -= 100;
                        hero.expirience++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money to buy. Returning to main page of the storage.\n\n");
                        break;
                    }
                }
                if (choice2 == 5)
                {
                    bool answer = checkIfEnoughMoney(100, hero);
                    if (answer)
                    {
                        hero.moneyAmount -= 100;
                        stick1.isAvailable = false;
                        stick2.isAvailable = true;
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
        public void sellFunction(Gender hero)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selling menu : \n");
                showAmounts(hero);
                Console.WriteLine("Options to sell : ");
                for (int i = 0; i < Goods.Count - 1; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] - " + Goods[i] + " - you get " + Costs[i] + " coins.");
                }
                Console.WriteLine("[0] - quit selling");
                Console.WriteLine("What do you want to sell : ");
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
                        Console.Clear();
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
                        Console.Clear();
                        Console.WriteLine("Not enough worms to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 3)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.fishJ_Amount);
                    if (answer)
                    {
                        hero.backpack.fishJ_Amount--;
                        hero.moneyAmount += Costs[2];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough fish to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 4)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.fishQ_Amount);
                    if (answer)
                    {
                        hero.backpack.fishQ_Amount--;
                        hero.moneyAmount += Costs[3];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough fish to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 5)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.fishK_Amount);
                    if (answer)
                    {
                        hero.backpack.fishK_Amount--;
                        hero.moneyAmount += Costs[4];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough fish to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 6)
                {
                    bool answer = checkIfEnoughItem(hero.backpack.fishA_Amount);
                    if (answer)
                    {
                        hero.backpack.fishA_Amount--;
                        hero.moneyAmount += Costs[5];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough fish to sell. Returning to the main menu of the storage.\n\n");
                        break;
                    }
                }
                if (choice == 0)
                {
                    break;
                }
            }
        }
        public bool checkIfEnoughMoney(int price, Gender hero)
        {
            if (hero.moneyAmount >= price)
            {
                return true;
            }
            return false;
        }
        public bool checkIfEnoughItem(int number)
        {
            if (number > 0)
            {
                return true;
            }
            return false;
        }
        public void showAmounts(Gender hero)
        {
            Console.WriteLine("Your amounts : ");
            Console.WriteLine("Money : " + hero.moneyAmount);
            Console.WriteLine("Bait : " + hero.backpack.equipment.baitAmount);
            Console.WriteLine("Worms : " + hero.backpack.equipment.wormsAmount);
            Console.WriteLine("Stick waist : " + hero.backpack.equipment.stick.waist);
            Console.WriteLine("Fish J : " + hero.backpack.fishJ_Amount);
            Console.WriteLine("Fish Q : " + hero.backpack.fishQ_Amount);
            Console.WriteLine("Fish K : " + hero.backpack.fishK_Amount);
            Console.WriteLine("Fish A : " + hero.backpack.fishA_Amount);
        }
    }
}
