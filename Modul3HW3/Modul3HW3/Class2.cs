using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    internal class Class2
    {
        private int z;
        public Predicate<int> Calc(Func<int, int, int> funcPow, int x, int y)
        {
            z = funcPow(x, y);
            return Result;
        }

        public bool Result(int x)
        {
            if (z % x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
