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
        public List<Fish> Fishes;
        public Publisher()
        {
            Fishes = new List<Fish>()
            {
                new FishJ(),
                new FishQ(),
                new FishK(),
                new FishA()
            };
        }
        public Fish notify()
        {

            int[] array = new int[Fishes.Count];
            array = generateArray();
            int maxNumber = array.Max();
            int maxIndex = array.Select((number, index) => new { Number = number, Index = index }).OrderByDescending(x => x.Number).First().Index;
            AbstractFactory factory;
            if (maxIndex == 0) factory = new FishJFactory();
            else if (maxIndex == 1) factory = new FishQFactory();
            else if (maxIndex == 2) factory = new FishKFactory();
            else factory = new FishAFactory();
            Fish fish = factory.createFish();
            return fish;
        }
        public int[] generateArray()
        {
            int[] array = new int[Fishes.Count];
            for(int i = 0; i<Fishes.Count; ++i)
            {
                array[i] = Fishes[i].randomIndex();
            }
            return array;
        }

    }
}
