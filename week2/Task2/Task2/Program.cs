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

        static bool IsPrime (int x)  //function to check whether number is prime
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
            List<int> vs = new List<int>();   //container to store primes
            string path = @"C:\Users\Технодом\Documents\PP2\week2\Task2\randomints.txt";  //path for input

            StreamReader sr = new StreamReader(path);  //Create the input reader

            string s = sr.ReadToEnd();   //read input
            string[] arr = s.Split();   //Split text and put it into an array
            for (int i = 0; i < arr.Length; ++i)
            {
                int x = int.Parse(arr[i]);  
                if (IsPrime(x) == true)   //check by using the function above
                {
                    vs.Add(x);
                }
            }
            sr.Close();

            string opath = @"C:\Users\Технодом\Documents\PP2\week2\Task2\Output.txt";  //path for output
            //Directory.CreateDirectory(folder);
            //string output = "output.txt";
            //folder = Path.Combine(folder, output);

            if (!File.Exists(opath))   //if file doesn't exist create it;
            {
                File.Create(opath);
            }
            else
            {
                using (var tw = new StreamWriter(opath, true))  //if it does then write primes in
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
