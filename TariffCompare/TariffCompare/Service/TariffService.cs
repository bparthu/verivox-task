using System;
using System.Collections.Generic;
using System.Text;
using TariffCompare.Domain;

namespace TariffCompare.Service
{
    public interface ITariffService
    {
        IEnumerable<IProduct> GetProducts(int usage);
    }

    public class TariffService : ITariffService
    {
        public IEnumerable<IProduct> GetProducts(int usage)
        {
            List<IProduct> products = new List<IProduct>();
            products.Add(new ProductA());
            products.Add(new ProductB());
            return products;
        } 
    }
}
