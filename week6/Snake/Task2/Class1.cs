using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Circle : Shape
    {
        public int r;
        public Circle(int x, int y, int z):base(x, y)
        {
            this.z = z;
        }
    }
}
