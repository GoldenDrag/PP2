using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime (int c)
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
            List<int> vs = new List<int>();
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string[] a = line2.Split();

            int n = int.Parse(line1);

            for (int i = 0; i < n; ++i)
            {
                int x = int.Parse(a[i]);
                if (Prime(x) == true)
                {
                    vs.Add(x);
                }
            }

            Console.WriteLine(vs.Count);

            for (int i = 0; i < vs.Count; ++i)
            {
                Console.Write(vs[i] + " ");
            }
        }
    }
}
