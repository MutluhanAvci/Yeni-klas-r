using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 50;
            int c = 75;
            var result = Add(ref a, b);
            var result2 = Add2(out c, b);
            Console.WriteLine(result2);
            Console.WriteLine(Add3(3,4,5));
            
            Console.WriteLine(result);
            Console.WriteLine(a);
        }
        static int Add(ref int a, int b)
        {
            a = 30;
            return a + b; 
        }
        static int Add2(out int x,int y)
        {
            x = 100;
            return x + y;
        }
        static int Add2(int x, int y , int z)
        {

            return x + y + z;
        }

        static int Add3(params int [] numbers)
        {
            return numbers.Sum();
        }


    }
}
