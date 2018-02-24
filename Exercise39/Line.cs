using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39
{
    class Line
    {
        private double length;

        public Line(double len)
        {
            Console.WriteLine("Object is being created");
            length = len;
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
            Line line = new Line(10.0);
            Console.WriteLine("Length of line: {0}", line.GetLength());

            line.SetLength(6.0);
            Console.WriteLine("Length of line: {0}", line.GetLength());
            Console.ReadKey();
        }
    }
}
