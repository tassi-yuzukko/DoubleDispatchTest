using DoubleDispatch3.Service;
using System;
using System.Threading;

namespace DoubleDispatch3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var cardNinshouService = new CardNinshouService();
                Console.WriteLine(cardNinshouService.Execute().X);
            }

            Console.ReadKey();
        }
    }
}
