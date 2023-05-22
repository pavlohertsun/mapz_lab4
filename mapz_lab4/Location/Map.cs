using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Location
{
    public class Map
    {
        enum LakeSymbols
        {
            LAND = 0,
            WATER = 1,
            PLAYER = 2,
            FISHJ = 3,
            FISHQ = 4,
            FISHK = 5,
            FISHA = 6
        }
        public Lake lake;
        public Map(Lake lake)
        {
            this.lake = lake;
        }

        private string printSymbols(string symbols, int times)
        {
            string symb = "";
            for (int i = 0; i < times; ++i) symb += symbols;
            return symb;
        }
        public void showLake()
        {
            string textLake = "\n\n\n\n";
            int spacesAmount = 20;
            int spacesFrom = 0;

            textLake += printSymbols(" ", spacesAmount);
            textLake += printSymbols("-", lake.location.size * 2 + 2 + spacesFrom * 2);
            textLake += "\n";

            for (int i = 0; i < lake.location.size; ++i)
            {
                for (int k = 0; k < spacesAmount; ++k) textLake += " ";
                textLake += "|";
                for (int j = 0; j < lake.location.size; ++j)
                {
                    if (lake.matrix[i, j] == (int)LakeSymbols.LAND)
                    {
                        textLake += "x ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.WATER)
                    {
                        textLake += "  ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.PLAYER)
                    {
                        textLake += "P ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.FISHJ)
                    {
                        textLake += "J ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.FISHQ)
                    {
                        textLake += "Q ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.FISHK)
                    {
                        textLake += "K ";
                    }
                    else if (lake.matrix[i, j] == (int)LakeSymbols.FISHA)
                    {
                        textLake += "A ";
                    }

                }
                textLake += "|\n";
            }
            textLake += printSymbols(" ", spacesAmount);
            textLake += printSymbols("-", lake.location.size * 2 + 2 + spacesFrom * 2);
            Console.WriteLine(textLake);
        }


    }
}
