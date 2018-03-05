using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace Exercise70
{
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
                return x;
            };

            nc(10);

            nc = new NumberChanger(AddNum);

            nc(5);

            nc = new NumberChanger(MultNum);

            nc(2);
            Console.ReadKey();
        }
    }
}
