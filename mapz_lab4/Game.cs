using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mapz_lab4
{
    public class Game
    {
        private static Game INSTANCE;
        Map map = new Map(LakeBuilder.lake1());
        private Game() { }
        public static Game getInstance() {
            if (INSTANCE == null) INSTANCE = new Game();
            return INSTANCE;
        }
        public void game(int sizeOfLocation)
        {
            Task.Run(ReadToConsoleAsync);
            Task.Run(SpawnFish);
            while (true)
            {
                Console.Clear();
                map.showLake();
                Thread.Sleep(500);
            }
        }
        async Task ReadToConsoleAsync()
        {
            while (true) {
                string input = Console.ReadLine();
                int index1 = 0;
                int index2 = 0;
                for (int i = 0; i < map.lake.size; ++i)
                {
                    for (int j = 0; j < map.lake.size; ++j) 
                    {
                        if (map.lake.matrix[i,j] == 2)
                        {
                            index1 = i;
                            index2 = j;
                        }
                    }
                }
                if (input == "w")
                {
                    if (index1 != 0)
                    {
                        if (map.lake.matrix[index1 - 1, index2] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            map.lake.matrix[index1 - 1, index2] = 2;
                        }
                    }
                }

                else if (input == "a")
                {
                    if (index2 != 0)
                    {
                        if (map.lake.matrix[index1, index2 - 1] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            map.lake.matrix[index1, index2 - 1] = 2;
                        }
                    }
                }
                     
                else if (input == "s")
                {
                    if (index1 != map.lake.size - 1)
                    {
                        if (map.lake.matrix[index1 + 1, index2] != 0)
                        {
                            map.lake.matrix[index1, index2] = 1;
                            map.lake.matrix[index1 + 1, index2] = 2;
                        }
                    }
                }
                    
                else if (input == "d")
                {
                    if (index2 != map.lake.size - 1)
                    {
                        if (map.lake.matrix[index1, index2 + 1] != 0) 
                        {
                            map.lake.matrix[index1, index2] = 1;
                            map.lake.matrix[index1, index2 + 1] = 2;
                        }
                    }
                }
                    

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
                else if (randomFishIndex == 3) factory = new FishQFactory();

                Fish fish = factory.createFish();
                randomFishIndex(map.lake, random, fish);
            }
        }
        private void randomFishIndex(Lake lake, Random random, Fish fish) {
            int index1 = random.Next(0, lake.size);
            int index2 = random.Next(0, lake.size);
            if (lake.matrix[index1, index2] == 0) randomFishIndex();
            else {
                int number = 0;
                if (fish.name = "J") number = 3;
                else if (fish.name = "Q") number = 4;
                else if(fish.name = "K") number = 5;
                else if(fish.name = "A") number = 6;
                lake.matrix[index1, index2] = number;
            }
        }
    }
}
