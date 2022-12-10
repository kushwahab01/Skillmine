using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    class UserTable
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            for(i=1; i<=10; i++)
            {
                for(j=1; j<=n; j++)
                {
                    Console.Write(" "+i*j);
                }
                Console.WriteLine();
            }
        }

    }
}
