using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int n = int.Parse(str);  //number of strings

            for (int i = 0; i <= n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write("[*]");  //full this strings
                }
                Console.WriteLine();
            }
        }
    }
}
