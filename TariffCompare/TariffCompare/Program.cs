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
            // int has the range of -2147483648 to 2147483647, which is more than enough for the input
            bool parsed = Int32.TryParse(args[0], out consumption);

            if(!parsed || consumption < 0)
            {
                throw new NotSupportedException("Please enter a valid number");
            }

            // setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITariffService, TariffService>()
                .BuildServiceProvider();

            var tariffService = serviceProvider.GetService<ITariffService>();

            Console.WriteLine("Below are our suggested products, sorted by annual tariff");
            Console.WriteLine("---------------------------------------------------------");

            using(IEnumerator<IProduct> productEnumerator = tariffService.GetProducts(consumption).GetEnumerator())
            {
                int i = 1;
                while (productEnumerator.MoveNext())
                {
                    IProduct product = productEnumerator.Current;
                    Console.WriteLine(i + ". " + product.Name + " : "+ product.AnnualTariff+" Euros");
                    i++;
                }
            }

            
        }
    }
}
