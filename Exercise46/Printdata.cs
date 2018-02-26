using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46
{
    class Printdata
    {
        void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void Print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        static void Main(string[] args)
        {
            Printdata p = new Printdata();

            p.Print(5);

            p.Print(500.263);

            p.Print("Hello C++");
            Console.ReadKey();
        }
    }
}
