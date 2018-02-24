using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40
{
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        ~Line()
        {
            Console.WriteLine("Object is being created");
        }
        public void SetLength(double len)
        {
            length = len;
        }
        public double GetLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();

            line.SetLength(6.0);
            Console.WriteLine("Length of Line: {0}", line.GetLength());
        }
    }
}
