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
        static void PrintSpaces(int level)  //function to make a spaces
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void FolderOpener(DirectoryInfo directory, int level)  //function to open every folder recusively
        {
            FileInfo[] files = directory.GetFiles();   //get files in folder
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)  //using function put spaces back to file names to show where is it contained
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)  //same thing with a folder and opening it immidietly
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                FolderOpener(d, level + 2);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Технодом\Documents\PP2\week2\Task3\gnome");  //path of top folder
            FolderOpener(d, 1);
        }
    }
}
