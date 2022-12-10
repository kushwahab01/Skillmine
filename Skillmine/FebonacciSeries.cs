using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    class FebonacciSeries
    {
        static void Main(string[] args)
        {
            int n,c, a = 0, b = 1;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);

            do
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            } while (c < n - a);
           

        }
    }
}
