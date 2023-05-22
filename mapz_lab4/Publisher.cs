using mapz_lab4.Factory;
using mapz_lab4.Fishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
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
            int index = rand.Next(0, Fishes.Count - 1);
            AbstractFactory factory;
            if (index == 0) factory = new FishAFactory();
            else if (index == 1) factory = new FishJFactory();
            else if (index == 2) factory = new FishKFactory();
            else factory = new FishQFactory();
            Fish fish = factory.createFish();
            return fish;
        }

    }
}
