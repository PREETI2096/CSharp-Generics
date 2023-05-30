using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MinString
    {
        public void findMinString(string n1, string n2, string n3)
        {
            if (n1.CompareTo(n2) <= 0 && n1.CompareTo(n3) <= 0)
            {
                Console.WriteLine(n1 + " is minimum ");
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