using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Minimum<T> where T : IComparable
    {

        T n1, n2, n3;


        public Minimum(T n1, T n2, T n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        public void testMinimum<T>() where T : IComparable<T>
        {
            if (n1.CompareTo(n2) <= 0 && n1.CompareTo(n3) <= 0)
            {
                Console.WriteLine(n1 + " is minimum");
            }
            else if (n2.CompareTo(n1) <= 0 && n2.CompareTo(n3) <= 0)
            {
                Console.WriteLine(n2 + " is minimum");
            }
            else
            {
                Console.WriteLine(n3 + " is minimum");
            }
        }
    }
}