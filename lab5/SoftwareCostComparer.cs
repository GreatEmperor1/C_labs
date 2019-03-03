﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class SoftwareCostComparer : IComparer<Software>
    {
        public int Compare(Software s1, Software s2)
        {
            if (s1.getCost() == s2.getCost())
            {
                return 1;
            }
            else if (s1.getCost() != s2.getCost())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
  //1 - если первый объект больше второго, 
  //-1 - если меньше, 
  //0 - если оба объекта равны.
