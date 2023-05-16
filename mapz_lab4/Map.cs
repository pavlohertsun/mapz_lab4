using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    class Map
    {
        enum LakeSymbols{
            LAND = 0,
            WATER = 1
        }
        private Lake lake;
        public Map(Lake lake) {
            this.lake = lake;
        }

        public void showLake() {
            string textLake = "\n\n\n\n";
            for (int i = 0; i < lake.size; ++i) {
                textLake += "                     ";
                for (int j = 0; j < lake.size; ++j) {
                    if (lake.matrix[i, j] == ((int)LakeSymbols.LAND)) {
                        textLake += "-";
                    }
                    else if (lake.matrix[i, j] == ((int)LakeSymbols.WATER))
                    {
                        textLake += "x";
                    }
                }
                textLake += "\n";
            }

            Console.WriteLine(textLake);
        }
    }
}
