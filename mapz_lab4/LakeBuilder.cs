﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4
{
    class LakeBuilder
    {
        public static Lake lake1() {
            int size = 20;
            Lake lake = new Lake(size);
            for (int i = 0; i < size ;++i) {
                for (int j = 0; j < size ; ++j)
                {
                    lake.matrix[i, j] = 1;
                }
            }
            int sizeOfLand1 = 2;
            for (int i = 10; i < size; ++i)
            {
                for (int j = 0; j < sizeOfLand1; ++j)
                {
                    lake.matrix[i, j] = 0;
                }
                sizeOfLand1++;
            }
            return lake;
        }
    }
}
