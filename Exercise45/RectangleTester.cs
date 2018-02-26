using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    public interface IPaintCost
    {
        int GetCost(int area);
    }
    class Rectangle: Shape, IPaintCost
    {
        public int GetArea()
        {
            return width * height;
        }
        public int GetCost(int area)
        {
            return area * 70;
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;

            Rect.SetWidth(5);
            Rect.SetHeight(7);
            area = Rect.GetArea();

            Console.WriteLine("Total area: {0}", Rect.GetArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.GetCost(area));
            Console.ReadKey();
        }
    }
}
