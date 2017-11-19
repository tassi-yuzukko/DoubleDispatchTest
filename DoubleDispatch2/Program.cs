using System;

namespace DoubleDispatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory.Create(1).Do();

            Console.ReadKey();
        }
    }
}
