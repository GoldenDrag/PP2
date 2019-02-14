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
            string soucepath = @"C:\Users\Технодом\Documents\PP2\week2\Task4\souce";
            string foodpath = @"C:\Users\Технодом\Documents\PP2\week2\Task4\food";

            string soucefile = Path.Combine(soucepath, filename);
            string foodfile = Path.Combine(foodpath, filename);

            if (!File.Exists(soucefile))
            {
                File.Create(soucefile);
            }
            else
            {
                File.Copy(soucefile, foodfile, true);

                File.Delete(@"C:\Users\Технодом\Documents\PP2\week2\Task4\souce\Szechuan.txt");
            }
        }
    }
}
