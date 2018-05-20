using System;
using System.Collections.Generic;
using System.Text;
using TariffCompare.constants;

namespace TariffCompare.Domain
{
    public interface IProduct
    {
        // This allows us to have different implementation of products
        IProduct CalculateTariff(int consumption);
        string Name { get; }
        double AnnualTariff { get; }
    }

    public class ProductA : ProductModel, IProduct
    {
        public ProductA()
        {
            name = "Basic electricity tariff";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double AnnualTariff
        {
            get
            {
                return annualTariff;
            }
        }

        public IProduct CalculateTariff(int consumption)
        {
            annualTariff = AppConstants.PRODUCT_A_BASE_TARIFF_PER_YEAR
                + (consumption * AppConstants.PRODUCT_A_COST_PER_kWh);

            return this;
        }
    }

    public class ProductB : ProductModel, IProduct
    {
        public ProductB()
        {
            name = "Packaged tariff";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double AnnualTariff
        {
            get
            {
                return annualTariff;
            }
        }

        public IProduct CalculateTariff(int consumption)
        {
            annualTariff = AppConstants.PRODUCT_B_BASE_TARIFF;
            if(consumption > AppConstants.PRODUCT_B_FLAT_USAGE_POLICY)
            {
                annualTariff += (consumption - AppConstants.PRODUCT_B_FLAT_USAGE_POLICY) * AppConstants.PRODUCT_B_COST_PER_kWh;
            }

            return this;
        }
    }
}
