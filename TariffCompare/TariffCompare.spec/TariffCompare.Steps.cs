using LightBDD.Framework;
using LightBDD.XUnit2;
using System;
using TariffCompare;
using TariffCompare.Service;
using Xunit;


	public partial class Tariff_Compare: FeatureFixture
	{
    private TariffService tariffService; 

        private void Throws_argument_exception()
        {
        string[] args = new string[0];
            Assert.Throws<ArgumentException>(() => Program.Main(args));
        }

		private void Initialize_tariff_service()
		{
        tariffService = new TariffService();
		}

		private void Get_product_list()
		{
        Assert.Throws<NotImplementedException>(() => tariffService.getProducts(1));
        }
	}
