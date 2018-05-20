using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using TariffCompare.Domain;
using TariffCompare.Service;

namespace TariffCompare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // validate if argument is sent
            if(args.Length != 1)
            {
                throw new ArgumentException("CONSUMPTION argument is not passed");
            }

            int consumption = 0;
            bool parsed = Int32.TryParse(args[0], out consumption);

            if(!parsed)
            {
                throw new NotSupportedException("Please enter a valid number");
            }

            // setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITariffService, TariffService>()
                .BuildServiceProvider();

            var tariffService = serviceProvider.GetService<ITariffService>();

            tariffService.GetProducts(consumption);
            
        }
    }
}
