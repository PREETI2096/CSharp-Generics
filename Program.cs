using System.Numerics;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MinInt minint = new MinInt();  
            minint.findMin(4,7,9);
            MinFloat minfloat = new MinFloat();
            minfloat.findMinfloat(3.2F, 4.6F, 10.1F);
            MinString minstring = new MinString();
            minstring.findMinString("banana", "apple", "biscuit");
            GenericMin genericMin = new GenericMin();
            genericMin.findMinimum<int>(5, 9, 6);
            Minimum<int> obj1 = new Minimum<int>(12, 6, 29);
            obj1.testMinimum<int>();
            Minimum<float> obj2 = new Minimum<float>(12.9F, 6.0F, 0.29F);
            obj2.testMinimum<float>();
            Minimum<string> obj3 = new Minimum<string>("above", "beyond", "upper");
            obj3.testMinimum<string>(); 

        }
    }
}