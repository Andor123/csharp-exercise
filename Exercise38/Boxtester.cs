using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public void SetLength(double len)
        {
            length = len;
        }
        public void SetBreadth(double bre)
        {
            breadth = bre;
        }
        public void SetHeight(double hei)
        {
            height = hei;
        }
        public double GetVolume()
        {
            return length * breadth * height;
        }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            Box1.SetLength(6.0);
            Box1.SetBreadth(7.0);
            Box1.SetHeight(5.0);

            Box2.SetLength(12.0);
            Box2.SetBreadth(13.0);
            Box2.SetHeight(10.0);

            volume = Box1.GetVolume();
            Console.WriteLine("Volume of Box1: {0}", volume);

            volume = Box2.GetVolume();
            Console.WriteLine("Volume of Box2: {0}", volume);

            Console.ReadKey();
        }
    }
}
