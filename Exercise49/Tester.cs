using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise49
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double GetVolume()
        {
            return length * breadth * height;
        }
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

        public static Box operator + (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
        public static bool operator == (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.breadth == rhs.breadth && lhs.height == rhs.height)
            {
                status = true;
            }
            return status;
        }
        public static bool operator != (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.breadth != rhs.breadth || lhs.height != rhs.height)
            {
                status = true;
            }
            return status;
        }
        public static bool operator < (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.breadth < rhs.breadth && lhs.height < rhs.height)
            {
                status = true;
            }
            return status;
        }
        public static bool operator > (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.breadth > rhs.breadth && lhs.height > rhs.height)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <= (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.breadth <= rhs.breadth && lhs.height <= rhs.height)
            {
                status = true;
            }
            return status;
        }
        public static bool operator >= (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.breadth >= rhs.breadth && lhs.height >= rhs.height)
            {
                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            Box Box4 = new Box();
            double volume = 0.0;

            Box1.SetLength(6.0);
            Box1.SetBreadth(7.0);
            Box1.SetHeight(5.0);

            Box2.SetLength(12.0);
            Box2.SetBreadth(13.0);
            Box2.SetHeight(10.0);

            Console.WriteLine("Box1: {0}", Box1.ToString());
            Console.WriteLine("Box2: {0}", Box2.ToString());

            volume = Box1.GetVolume();
            Console.WriteLine("Volume of Box1: {0}", volume);

            volume = Box2.GetVolume();
            Console.WriteLine("Volume of Box2: {0}", volume);

            Box3 = Box1 + Box2;
            Console.WriteLine("Box3: {0}", Box3.ToString());

            volume = Box3.GetVolume();
            Console.WriteLine("Volume of Box3: {0}", volume);

            if (Box1 > Box2)
                Console.WriteLine("Box1 is greater then Box2");
            else
                Console.WriteLine("Box1 is not greater then Box2");

            if (Box1 < Box2)
                Console.WriteLine("Box1 is less then Box2");
            else
                Console.WriteLine("Box1 is not less then Box2");

            if (Box1 >= Box2)
                Console.WriteLine("Box1 is greater or equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");

            if (Box1 <= Box2)
                Console.WriteLine("Box1 is less or equal to Box2");
            else
                Console.WriteLine("Box1 is not less or equal to Box2");

            if (Box1 != Box2)
                Console.WriteLine("Box1 is not equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");
            Box4 = Box3;

            if (Box3 == Box4)
                Console.WriteLine("Box3 is equal to Box4");
            else
                Console.WriteLine("Box3 is not equal to Box4");

            Console.ReadKey();
        }
    }
}
