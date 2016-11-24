using System;
using System.ServiceModel;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var cf = new ChannelFactory<ICalculatorServiceChannel>("calculator");

            using (var ch = cf.CreateChannel())
            {
                Console.WriteLine(ch.Add(4, 5));
                Console.ReadKey();
            }
        }
    }
}
