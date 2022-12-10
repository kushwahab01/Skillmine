using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine
{
    public class ParamKeyword
    {
        
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Value to print" + names.Length);
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
            }
            static void Main(string[] args)
            {
                AcceptNames("Brijesh");
                AcceptNames("Brijesh", "Sanjeev");
                AcceptNames("Brijesh", "Sanjeev", "Abhishek");
                AcceptNames("Brijesh", "Sanjeev", "Abhi", "Akash");
            }
        }
    }

