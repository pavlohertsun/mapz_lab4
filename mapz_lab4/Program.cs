using System;

namespace mapz_lab4{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - start a game");
            Console.WriteLine("[0] - quit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                    case 1:
                    {
                        startGameMenu menu = new startGameMenu();
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