using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static bool IsPrime (int x)
        {
            if (x < 2) return false;

            double n = Math.Sqrt(x);

            for (int i = 2; i <= n; ++i)
            {
                if (x % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            string path = @"C:\Users\Технодом\Documents\PP2\week2\Task2\randomints.txt";

            StreamReader sr = new StreamReader(path);

            string s = sr.ReadToEnd();
            string[] arr = s.Split();
            for (int i = 0; i < 7; ++i)
            {
                int x = int.Parse(arr[i]);
                if (IsPrime(x) == true)
                {
                    vs.Add(x);
                }
            }

            string opath = @"C:\Users\Технодом\Documents\PP2\week2\Task2\Output.txt";
            //Directory.CreateDirectory(folder);
            //string output = "output.txt";
            //folder = Path.Combine(folder, output);

            if (!File.Exists(opath))
            {
                File.Create(opath);
            }
            else
            {
                using (var tw = new StreamWriter(opath, true))
                {
                    for (int i = 0; i < vs.Count; ++i)
                    {
                        tw.Write(vs[i] + " ");
                    }
                    tw.Close();
                }

                return;
            }
        }
    }
}
