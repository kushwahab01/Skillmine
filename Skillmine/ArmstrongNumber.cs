using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int n, temp, sum = 0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            temp = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
              

            }
            if(temp==sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not armstrong");
            }
        }

    }
}
