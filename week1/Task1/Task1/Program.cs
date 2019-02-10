using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime (int c)  //funtion for finding odds
        {
            if (c < 2) return false;

            double s = Math.Sqrt(c);

            for (int i = 2; i <= s; ++i)
            {
                if (c % i == 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();  //vector where we will contain add integers
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string[] a = line2.Split();  

            int n = int.Parse(line1);  //number of integers

            for (int i = 0; i < n; ++i)
            {
                int x = int.Parse(a[i]);  //integers of an array
                if (Prime(x) == true)
                {
                    vs.Add(x);   //containing add integers
                }
            }

            Console.WriteLine(vs.Count);  //number of odd integers

            for (int i = 0; i < vs.Count; ++i)
            {
                Console.Write(vs[i] + " ");  //final output
            }
        }
    }
}
