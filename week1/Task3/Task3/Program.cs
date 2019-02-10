using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int n = int.Parse(line1); //number of integers
            string[] arr = line2.Split(); //array

            for (int i = 0; i < n; ++i)
            {
                int x = int.Parse(arr[i]);  //integers
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
