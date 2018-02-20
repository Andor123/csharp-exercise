using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
            Console.ReadLine();
        }
    }
}
