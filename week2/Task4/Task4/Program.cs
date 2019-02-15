using System;
using System.IO;
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
            string filename = "Szechuan.txt";
            string soucepath = @"C:\Users\Технодом\Documents\PP2\week2\Task4\souce";  //Source path where file creates
            string foodpath = @"C:\Users\Технодом\Documents\PP2\week2\Task4\food";  //Target path where file will copy

            string soucefile = Path.Combine(soucepath, filename);  //new source path
            string foodfile = Path.Combine(foodpath, filename);  //new target path;
            //we can declare path without Path.Combine : string soucepath = @"C:\Users\Технодом\Documents\PP2\week2\Task4\souce\Szechuan.txt"
            if (!File.Exists(soucefile))
            {
                File.Create(soucefile);  //If file doesn't exist create it;
            }
            else
            {
                File.Copy(soucefile, foodfile, true);  //Copy file from source path to target path

                File.Delete(@"C:\Users\Технодом\Documents\PP2\week2\Task4\souce\Szechuan.txt");  //delete the original file from source path
            }
        }
    }
}
