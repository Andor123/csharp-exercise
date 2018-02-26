using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47
{
    abstract class Shape
    {
        public abstract int Area();
    }
    class Rectangle: Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int Area()
        {
            Console.WriteLine("Rectangle class area: ");
            return (width * length);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.Area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }
}
