using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Objects
{
    class LakeBuilder
    {
        public static Lake lake1()
        {
            List<string> list = new List<string>();
            list.Add("J");
            list.Add("Q");
            Lake lake = new Lake(new Location("Svityaz", 20, list));

            for (int i = 0; i < lake.location.size; ++i)
            {
                for (int j = 0; j < lake.location.size; ++j)
                {
                    lake.matrix[i, j] = 1;
                }
            }
            int sizeOfLand1 = 2;
            for (int i = 10; i < lake.location.size; ++i)
            {
                for (int j = 0; j < sizeOfLand1; ++j)
                {
                    lake.matrix[i, j] = 0;
                }
                sizeOfLand1++;
            }
            lake.matrix[5, 4] = 2;
            return lake;
        }
    }
}
