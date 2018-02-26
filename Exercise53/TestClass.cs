using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_space;
using first_space.second_space;

namespace first_space
{
    class Abc
    {
        public void Func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
    namespace second_space
    {
        class Efg
        {
            public void Func()
            {
                Console.WriteLine("Inside second_space");
            }
        }
    }
}
namespace Exercise53
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Abc fc = new Abc();
            Efg sc = new Efg();
            fc.Func();
            sc.Func();
            Console.ReadKey();
        }
    }
}
