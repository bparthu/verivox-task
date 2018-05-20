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

    private void Given_the_yearly_energy_consumption_at_1000_kWh_per_year()
    {
        productList = tariffService.GetProducts(1000).ToList();
    }

    private void ProductA_and_ProductB_should_be_displayed_in_same_order()
    {
        Assert.True(typeof(ProductA).Equals(productList.ElementAt(0).GetType()));
        Assert.True(typeof(ProductB).Equals(productList.ElementAt(1).GetType()));
    }
}