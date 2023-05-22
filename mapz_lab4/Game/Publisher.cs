using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Objects
{
    public class Publisher
    {
        public List<string> Fishes;
        public Publisher()
        {
            Fishes = new List<string>()
            {
                "Fish J",
                "Fish Q",
                "Fish K",
                "Fish A"
            };
        }
        public Fish randomFishToSpawn()
        {
            Random rand = new Random();
            int[] array = new int[Fishes.Count];
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < Fishes.Count; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < Fishes.Count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            AbstractFactory factory;
            if (index == 0) factory = new FishJFactory();
            else if (index == 1) factory = new FishQFactory();
            else if (index == 2) factory = new FishKFactory();
            else factory = new FishAFactory();
            Fish fish = factory.createFish();
            return fish;
        }

    }
}
