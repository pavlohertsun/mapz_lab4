using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    class LakeBuilder
    {
        public static Lake lake1() {
            int size = 15;
            Lake lake = new Lake(size);

            for (int i = 0; i < size ;++i) {
                for (int j = 0; j < size ; ++j)
                {
                    lake.matrix[i, j] = 1;
                }
            }
            lake.matrix[0,0] = 0;
            lake.matrix[0,1] = 0;
            lake.matrix[0,2] = 0;
            lake.matrix[0,3] = 0;
            lake.matrix[0,4] = 0;
            lake.matrix[0,5] = 0;
            return lake;
        }
        public static Lake Lake2()
        {
            int size = 15;
            Lake lake = new Lake(size);

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    lake.matrix[i, j] = 1;
                }
            }
            return lake;

        }
    }
}
