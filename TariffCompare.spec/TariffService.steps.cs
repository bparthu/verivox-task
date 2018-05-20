using LightBDD.Framework;
using LightBDD.XUnit2;
using System;
using System.Collections;
using System.Collections.Generic;
using TariffCompare;
using TariffCompare.Domain;
using TariffCompare.Service;
using Xunit;
using System.Linq;


public partial class Tariff_Service : FeatureFixture
{
    ITariffService tariffService = new TariffService();
    List<IProduct> productList;
    private void Given_the_yearly_energy_consumption_at_0_kWh_per_year()
    {
        productList = tariffService.GetProducts(0).ToList();
    }

    private void ProductA_is_cheaper_with_an_annual_estimate_as_60_Euro()
    {
        double expected = 60;
        Assert.Equal(expected, productList.ElementAt(0).AnnualTariff);
    }

    private void ProductB_should_have_annual_estimate_as_800_Euro()
    {
        double expected = 800;
        Assert.Equal(expected, productList.ElementAt(1).AnnualTariff);
    }


}

public partial class Tariff_Service : FeatureFixture
{
   

    private void Given_the_yearly_energy_consumption_at_3500_kWh_per_year()
    {
        productList = tariffService.GetProducts(3500).ToList();
    }

    private void Order_of_product_list_should_be_ProductB_and_then_ProductA()
    {
        Assert.True(typeof(ProductB).Equals(productList.ElementAt(0).GetType()));
        Assert.True(typeof(ProductA).Equals(productList.ElementAt(1).GetType()));
    }

    private void ProductB_is_cheaper_with_an_annual_estimate_as_800_Euro()
    {
        double expected = 800;
        Assert.Equal(expected, productList.ElementAt(0).AnnualTariff);
    }

    private void ProductA_should_have_annual_estimate_as_830_Euro()
    {
        double expected = 830;
        Assert.Equal(expected, productList.ElementAt(1).AnnualTariff);
    }
}

public partial class Tariff_Service : FeatureFixture
{

    private void Given_the_yearly_energy_consumption_at_4500_kWh_per_year()
    {
        productList = tariffService.GetProducts(4500).ToList();
    }

    private void ProductB_is_cheaper_with_an_annual_estimate_as_950_Euro()
    {
        double expected = 950;
        Assert.Equal(expected, productList.ElementAt(0).AnnualTariff);
    }

    private void ProductA_should_have_annual_estimate_as_1050_Euro()
    {
        double expected = 1050;
        Assert.Equal(expected, productList.ElementAt(1).AnnualTariff);
    }
}

public partial class Tariff_Service : FeatureFixture
{

    private void Given_the_yearly_energy_consumption_at_6000_kWh_per_year()
    {
        productList = tariffService.GetProducts(6000).ToList();
    }

    private void Order_of_product_list_should_be_ProductA_and_then_ProductB()
    {
        Assert.True(typeof(ProductA).Equals(productList.ElementAt(0).GetType()));
        Assert.True(typeof(ProductB).Equals(productList.ElementAt(1).GetType()));
    }

    private void ProductA_is_cheaper_with_an_annual_estimate_as_1380_Euro()
    {
        double expected = 1380;
        Assert.Equal(expected, productList.ElementAt(0).AnnualTariff);
    }

    private void ProductB_should_have_annual_estimate_as_1400_Euro()
    {
        double expected = 1400;
        Assert.Equal(expected, productList.ElementAt(1).AnnualTariff);
    }

    
}


