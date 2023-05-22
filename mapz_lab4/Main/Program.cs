using System;

namespace mapz_lab4.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there. Welcome to my game.\nPress to:");
            Console.WriteLine("[1] - start a game");
            Console.WriteLine("[0] - quit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Fasad menu = new Fasad();
                        menu.printTable();
                        break;
                    }
                case 0:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}