using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    enum FSIMode
    {
        DirectoryInfo = 1,
        File = 2
    }

    class Layer
    {
        public FileSystemInfo[] Content  //gives access to files
        {
            get;
            set;
        }
        public int SelectedIndex  //work as cursor
        {
            get;
            set;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;  //Make background color
            Console.Clear();       //this is needed to refresh console each time we switch cursor so
            for (int i = 0; i < Content.Length; ++i)  //give an index to cursor, so we could move it 
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;   //make a selected string stand out to determine its position
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Content[i].Name);  //show the name of selected file/directory
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Технодом\Documents\PP2\week2\Task3\gnome");  //path to directory that we are going to manage
            Layer l = new Layer 
            {
                Content = dir.GetFileSystemInfos(),  
                SelectedIndex = 0
            };


            FSIMode curMode = FSIMode.DirectoryInfo;

            Stack<Layer> history = new Stack<Layer>();  //create a Stack
            history.Push(l);  //fill the stack

            bool esc = false;  //bool for run the loop
            while (!esc)  
            {
                if (curMode == FSIMode.DirectoryInfo)
                {
                    history.Peek().Draw();  //shows files
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();  //inter key batton that will move cursor
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedIndex++;
                        break;
                    case ConsoleKey.Enter: //goes further to the directory (if it is folder)
                        int index = history.Peek().SelectedIndex;  //when we open a directory cursor goes on top of files which directory contains
                        FileSystemInfo fsi = history.Peek().Content[index];  //"open" a directory/file
                        if (fsi.GetType() == typeof(DirectoryInfo))  //if it is directory
                        {
                            curMode = FSIMode.DirectoryInfo;
                            DirectoryInfo d = fsi as DirectoryInfo;
                            history.Push(new Layer
                            {
                                Content = d.GetFileSystemInfos(),
                                SelectedIndex = 0
                            });
                        }
                        else  //if it is file
                        {
                            curMode = FSIMode.File;
                            using (FileStream fs = new FileStream(fsi.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:  //shuts directory or file
                        if (curMode == FSIMode.DirectoryInfo)
                        {
                            history.Pop();
                        }
                        else
                        {
                            curMode = FSIMode.DirectoryInfo;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Delete:
                        int x2 = history.Peek().SelectedIndex;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x2];
                        history.Peek().SelectedIndex--;
                        if (fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo2 as DirectoryInfo;
                            Directory.Delete(fileSystemInfo2.FullName, true);
                            history.Peek().Content = directoryInfo.Parent.GetFileSystemInfos();
                        }
                        else
                        {
                            FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                            File.Delete(fileSystemInfo2.FullName);
                            history.Peek().Content = fileInfo.Directory.GetFileSystemInfos();
                        }


                        break;
                    case ConsoleKey.Escape:  //shuts console
                        esc = true;
                        break;
                }
            }
        }
    }
}
