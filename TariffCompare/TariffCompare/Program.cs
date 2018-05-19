using System;
using Microsoft.Extensions.DependencyInjection;
using TariffCompare.Service;

namespace TariffCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITariffService, TariffService>()
                .BuildServiceProvider();

            var tariffService = serviceProvider.GetService<ITariffService>();

            tariffService.getProducts(2);

            
        }
    }
}
