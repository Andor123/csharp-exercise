#define DEBUG
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise59
{
    public class MyClass
    {
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Test
    {
        static void Function1()
        {
            MyClass.Message("In Function 1.");
            Function2();
        }
        static void Function2()
        {
            MyClass.Message("In Function 2.");
        }
        public static void Main()
        {
            MyClass.Message("In Main function.");
            Function1();
            Console.ReadKey();
        }
    }
}
