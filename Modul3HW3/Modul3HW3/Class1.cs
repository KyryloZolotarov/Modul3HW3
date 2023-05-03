using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    internal class Class1
    {
        public Action<bool> ShowAction { get; set; }
        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
