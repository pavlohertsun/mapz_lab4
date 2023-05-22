using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using mapz_lab4.Hero;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class GlobalVariables
{
    public static bool finish = false;
    public static int iterator = 0;
    public static bool notify = false;
}

namespace mapz_lab4.Objects
{
    public class DefaultGame : Game
    {
        private static DefaultGame INSTANCE;
        public Map map;
        public DefaultGame() { }
        public static DefaultGame getInstance()
        {
            if (INSTANCE == null) INSTANCE = new DefaultGame();
            return INSTANCE;
        }
        public override void game(int size, Man hero, Stick stick, bool useBait)
        {
            GlobalVariables.finish = false;
            map = new Map(LakeBuilder.lake1());
            Task.Run(() => ReadToConsoleAsync(hero, stick));
            Task.Run(() => SpawnFish(useBait));
            while (true)
            {
                Console.Clear();
                map.showLake();
                Thread.Sleep(500);
                if (GlobalVariables.finish) break;
            }
        }
        async Task ReadToConsoleAsync(Man hero, Stick stick)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int index1 = 0;
                int index2 = 0;
                for (int i = 0; i < map.lake.location.size; ++i)
                {
                    for (int j = 0; j < map.lake.location.size; ++j)
                    {
                        if (map.lake.matrix[i, j] == 2)
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
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishJ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 4)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishQ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 5)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishK_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);

                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 - 1, index2] == 6)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishA_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
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
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishJ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 4)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishQ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 5)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishK_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 - 1] == 6)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishA_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
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
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishJ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 4)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishQ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 5)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishK_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1 + 1, index2] == 6)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishA_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
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
                            if (map.lake.matrix[index1, index2 + 1] == 3)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishJ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 + 1] == 4)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishQ_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 + 1] == 5)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishK_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);
                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            if (map.lake.matrix[index1, index2 + 1] == 6)
                            {
                                if (checkIfEnoughWorms(hero))
                                {
                                    if (checkIfCatched(stick))
                                    {
                                        hero.backpack.fishA_Amount++;
                                        GlobalVariables.iterator++;
                                        changeCharacter(hero);

                                    }
                                    else
                                    {
                                        changeCharacter(hero);
                                    }
                                    bool breakFishing = hero.backpack.equipment.subWorm();
                                    if (breakFishing)
                                    {
                                        GlobalVariables.finish = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    GlobalVariables.finish = true;
                                    break;
                                }
                            }
                            map.lake.matrix[index1, index2 + 1] = 2;
                        }
                    }
                }
                else if (input == "0")
                {
                    GlobalVariables.finish = true;
                }
                if (GlobalVariables.finish)
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
        async Task SpawnFish(bool useBait)
        {
            Random random = new Random();
            Publisher publisher = new Publisher();
            while (true)
            {
                int time = 0;
                if (useBait)
                {
                    time = 3;
                }
                else time = random.Next(4, 7);
                Thread.Sleep(time * 1000);
                Fish fish = publisher.randomFishToSpawn();
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
            int time = random.Next(10, 20);
            Thread.Sleep(time * 1000);
            lake.matrix[fish.index1, fish.index2] = 1;
        }
        public void changeCharacter(Man hero)
        {
            hero.stamina -= 2;
            hero.attentiveness += 0.2;
            hero.skills += 0.2;
            if (GlobalVariables.iterator == 10)
            {
                hero.expirience++;
                GlobalVariables.iterator = 0;
            }
        }
        public bool checkIfEnoughWorms(Man hero)
        {
            if (GlobalVariables.notify)
            {
                return false;
            }
            return true;
        }
        public bool checkIfCatched(Stick stick)
        {
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            if (chance < stick.chanceToCatch)
            {
                return true;
            }
            return false;
        }
    }
}
