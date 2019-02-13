using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void FolderOpener(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                FolderOpener(d, level + 2);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Технодом\Documents\PP2\week2\Task3\gnome");
            FolderOpener(d, 1);
        }
    }
}
