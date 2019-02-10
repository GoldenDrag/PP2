using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public int id;
        public int year;

        public Student()
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
        }

        public Student(string name, int id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = ++year;
        }

        public string ToTring()
        {
            return name + " " + id + " " + year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student("aaa", 18081139, 1);
            Console.WriteLine(st1);
            Console.WriteLine(st2);
        }
    }
}
