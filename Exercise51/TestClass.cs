using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_space
{
    class Namespace_cl
    {
        public void Func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class Namespace_cl
    {
        public void Func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
namespace Exercise51
{
    class TestClass
    {
        static void Main(string[] args)
        {
            first_space.Namespace_cl fc = new first_space.Namespace_cl();
            second_space.Namespace_cl sc = new second_space.Namespace_cl();
            fc.Func();
            sc.Func();
            Console.ReadKey();
        }
    }
}
