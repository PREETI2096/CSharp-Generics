﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MinFloat
    {
        public void findMinfloat(float n1, float n2, float n3)
        {
            if (n1.CompareTo(n2) <= 0 && n1.CompareTo(n3) <= 0)
            {
                Console.WriteLine(n1 + " is minimum number.");
            }
            else if (n2.CompareTo(n1) <= 0 && n2.CompareTo(n3) <= 0)
            {
                Console.WriteLine(n2 + " is minimum number");
            }
            else
            {
                Console.WriteLine(n3 + " is minimum number");
            }
        }
    }
}

