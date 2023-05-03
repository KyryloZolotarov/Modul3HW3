using System.Security.Cryptography.X509Certificates;

namespace Modul3HW3
{
    internal class Program
    {
        internal static void Main()
        {
            var class1 = new Class1();
            var class2 = new Class2();
            class1.ShowAction = Show;
            var calc = class2.Calc(class1.Pow, 10, 20);
            var result = calc.Invoke(10);
            class1.ShowAction.Invoke(result);
            void Show(bool result)
            {
                Console.WriteLine(result);
            }
        }
    }
}