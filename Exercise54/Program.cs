#define PI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise54
{
    class Program
    {
        static void Main(string[] args)
        {
#if (PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.ReadKey();
        }
    }
}
