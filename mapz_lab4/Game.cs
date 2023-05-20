using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class GlobalVariables
{
    public static bool finish = false;
}

namespace mapz_lab4
{
    public class Game
    {
        private static Game INSTANCE;
        public Map map;
        private Game() { }
        public static Game getInstance() {
            if (INSTANCE == null) INSTANCE = new Game();
            return INSTANCE;
        }
        public void game(int size, Character hero)
        {
            map = new Map(LakeBuilder.lake1());
            Task.Run(() => ReadToConsoleAsync(hero));
            Task.Run(SpawnFish);
            while(true)  
            {
                Console.Clear();
                map.showLake();
                Thread.Sleep(500);
                if(GlobalVariables.finish) break;
            }
        }
        async Task ReadToConsoleAsync(Character hero)
        {
            while (true) {
                string input = Console.ReadLine();
                int index1 = 0;
                int index2 = 0;
                for (int i = 0; i < map.lake.location.size; ++i)
                {
                    for (int j = 0; j < map.lake.location.size; ++j) 
                    {
                        if (map.lake.matrix[i,j] == 2)
                        {
                            index1 = i;
                            index2 = j;
                        }
                    }
                }
                if (input == "w" || input == "W")
                {
                    if (index1 != 0)
                    {
                        if (map.lake.matrix[index1 - 1, index2] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            if (map.lake.matrix[index1 - 1, index2] == 3)
                            {
                                hero.backpack.fishJ_Amount++;
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 4)
                            {
                                hero.backpack.fishQ_Amount++;
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 5)
                            {
                                hero.backpack.fishK_Amount++;
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 6)
                            {
                                hero.backpack.fishA_Amount++;
                            }
                            map.lake.matrix[index1 - 1, index2] = 2;
                        }
                    }
                }

                else if (input == "a" || input == "A")
                {
                    if (index2 != 0)
                    {
                        if (map.lake.matrix[index1, index2 - 1] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            if (map.lake.matrix[index1, index2 - 1] == 3)
                            {
                                hero.backpack.fishJ_Amount++;
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 4)
                            {
                                hero.backpack.fishQ_Amount++;
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 5)
                            {
                                hero.backpack.fishK_Amount++;
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 6)
                            {
                                hero.backpack.fishA_Amount++;
                            }
                            map.lake.matrix[index1, index2 - 1] = 2;
                        }
                    }
                }
                     
                else if (input == "s" || input == "S")
                {
                    if (index1 != map.lake.location.size - 1)
                    {
                        if (map.lake.matrix[index1 + 1, index2] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            if (map.lake.matrix[index1 + 1, index2] == 3)
                            {
                                hero.backpack.fishJ_Amount++;
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 4)
                            {
                                hero.backpack.fishQ_Amount++;
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 5)
                            {
                                hero.backpack.fishK_Amount++;
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 6)
                            {
                                hero.backpack.fishA_Amount++;
                            }
                            map.lake.matrix[index1 + 1, index2] = 2;
                        }
                    }
                }
                    
                else if (input == "d" || input == "D")
                {
                    if (index2 != map.lake.location.size - 1)
                    {
                        if (map.lake.matrix[index1, index2 + 1] != 0) 
                        {
                            map.lake.matrix[index1, index2] = 1;
                            if(map.lake.matrix[index1, index2 + 1] == 3)
                            {
                                hero.backpack.fishJ_Amount++;
                            }
                            if(map.lake.matrix[index1, index2 + 1] == 4)
                            {
                                hero.backpack.fishQ_Amount++;
                            }
                            if(map.lake.matrix[index1, index2 + 1] == 5)
                            {
                                hero.backpack.fishK_Amount++;
                            }
                            if(map.lake.matrix[index1, index2 + 1] == 6)
                            {
                                hero.backpack.fishA_Amount++;
                            }
                            map.lake.matrix[index1, index2 + 1] = 2;
                        }
                    }
                }
                else if(input == "0")
                {
                    GlobalVariables.finish = true;
                }
                if(GlobalVariables.finish)
                {
                    break;
                }
            }
        }
        public void randomFishIndexFunc(Lake lake, Random random, Fish fish)
        {
            fish.index1 = random.Next(0, lake.location.size);
            fish.index2 = random.Next(0, lake.location.size);
            if (lake.matrix[fish.index1, fish.index2] == 0) randomFishIndexFunc(lake, random, fish);
            else
            {
                int number = 0;
                if (fish.name == "J") number = 3;
                else if (fish.name == "Q") number = 4;
                else if (fish.name == "K") number = 5;
                else if (fish.name == "A") number = 6;
                lake.matrix[fish.index1, fish.index2] = number;
            }
        }
        async Task SpawnFish()
        {
            Random random = new Random();
            AbstractFactory factory;
            while (true) {
                int time = random.Next(10,20);
                Thread.Sleep(time * 1000);
                int randomFishIndex = random.Next(0,3);

                if (randomFishIndex == 0) factory = new FishAFactory();
                else if (randomFishIndex == 1) factory = new FishJFactory();
                else if (randomFishIndex == 2) factory = new FishKFactory();
                else  factory = new FishQFactory();

                Fish fish = factory.createFish();
                randomFishIndexFunc(map.lake, random, fish);
                Task.Run(() => DeleteFish(fish, random, map.lake));
                if (GlobalVariables.finish)
                {
                    break;
                }
            }

        }
        async Task DeleteFish(Fish fish, Random random, Lake lake)
        {
            int time = random.Next(10,20);
            Thread.Sleep(time * 1000);
            lake.matrix[fish.index1, fish.index2] = 1;
        }
    }
}
