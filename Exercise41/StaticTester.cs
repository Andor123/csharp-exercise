using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41
{
    class StaticVar
    {
        public static int num;

        public void Count()
        {
            num++;
        }
        public int GetNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.Count();
            s1.Count();
            s1.Count();

            s2.Count();
            s2.Count();
            s2.Count();

            Console.WriteLine("Variable num for s1: {0}", s1.GetNum());
            Console.WriteLine("Variable num for s2: {0}", s2.GetNum());
            Console.ReadKey();
        }
    }
}
