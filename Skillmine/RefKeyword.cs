using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    class RefKeyword
    {
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before call the method a={a} , b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"After swapig the method a={a} , b={b}");
        }
    }
}
