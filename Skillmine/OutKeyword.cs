using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    public class OutKeyword
    {
        static void Calc(int a, int b,out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;

        }
        static void Main(string[] args)
        {
            int a = 15, b = 12;
            int sum, sub, mul;
            Calc(a, b, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
        }
    }
}
