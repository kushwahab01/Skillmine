using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    class CountNumber
    {

        static void Main(string[] args)
        {
            int n, i,digit=0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            do
            {
                n = n / 10;
                digit++;
            } while (n != 0);
            Console.WriteLine(digit);
        }
    }
}
