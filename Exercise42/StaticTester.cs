using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
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
            StaticVar s = new StaticVar();

            s.Count();
            s.Count();
            s.Count();

            Console.WriteLine("Variable num: {0}", s.GetNum());
            Console.ReadKey();
        }
    }
}
