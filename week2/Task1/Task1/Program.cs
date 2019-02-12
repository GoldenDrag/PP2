using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Palindrome(string pal)  //function to check whether is string palindrome
        {
            string part1 = pal.Substring(0, pal.Length / 2); //cut a half of string
            char[] arr = pal.ToCharArray();  //turn it into an array to reverse it

            Array.Reverse(arr);

            string temp = new string(arr);  //turn back into a string
            string part2 = temp.Substring(0, temp.Length / 2);  //cut in half again

            return part1.Equals(part2); //if they equal return true
        }

        static void fileinfotest()
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\Технодом\Documents\PP2\week2\Task1\ababa.txt");
            Console.WriteLine(fileinfo.Name);
            Console.WriteLine(fileinfo.FullName);
            Console.WriteLine(fileinfo.Directory);
        }

        static void directoryinfotest()
        {
            DirectoryInfo directoryinfo = new DirectoryInfo(@"C:\Users\Технодом\Documents\PP2\week2\Task1");
            Console.WriteLine(directoryinfo.Name);
            Console.WriteLine(directoryinfo.FullName);
            Console.WriteLine(directoryinfo.Parent);
        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\Технодом\Documents\PP2\week2\Task1\ababa.txt";

            StreamReader sr = new StreamReader(path);
            string s = sr.ReadToEnd();
            if (Palindrome(s) == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
