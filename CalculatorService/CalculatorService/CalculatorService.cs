using System;

namespace CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"a={a} en b={b}");
            return a + b;
        }
    }
}
