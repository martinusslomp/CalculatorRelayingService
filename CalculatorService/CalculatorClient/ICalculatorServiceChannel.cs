using CalculatorService;
using System.ServiceModel;

namespace CalculatorClient
{
    interface ICalculatorServiceChannel : ICalculatorService, IClientChannel
    {
    }
}
