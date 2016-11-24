using CalculatorService;
using System;
using System.ServiceModel;

namespace CalculatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(CalculatorService));
            sh.Open();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
            sh.Close();
        }
    }
}
