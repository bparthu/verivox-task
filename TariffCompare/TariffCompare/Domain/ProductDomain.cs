using System;
using System.Collections.Generic;
using System.Text;

namespace TariffCompare.Domain
{
    public interface IProduct
    {
        // This allows us to have different implementation of products
        int GetTariff(int consumption);
        string GetName();
    }

    public class ProductA : ProductModel, IProduct
    {
        public ProductA()
        {
            Name = "Basic electricity tariff";
        }

        public string GetName()
        {
            return Name;
        }

        public int GetTariff(int consumption)
        {
            throw new NotImplementedException();
        }
    }

    public class ProductB : ProductModel, IProduct
    {
        public ProductB()
        {
            Name = "Packaged tariff";
        }

        public string GetName()
        {
            return Name;
        }

        public int GetTariff(int consumption)
        {
            throw new NotImplementedException();
        }
    }
}
