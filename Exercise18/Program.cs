using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

                if (a > 15)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
