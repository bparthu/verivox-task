using LightBDD.Framework;
using LightBDD.XUnit2;
using System;
using TariffCompare;
using TariffCompare.Service;
using Xunit;


public partial class Input_Validation : FeatureFixture
{
    private TariffService tariffService; 

    private void If_CONSUMPTION_argument_is_not_provided()
    {
    string[] args = new string[0];
        Assert.Throws<ArgumentException>(() => Program.Main(args));
    }

    private void If_CONSUMPTION_argument_contains_empty_string()
    {
        string[] args = new string[1];
        args[0] = "";
        Assert.Throws<NotSupportedException>(() => Program.Main(args));
    }

    private void If_CONSUMPTION_argument_contains_invalid_input()
    {
        string[] args = new string[1];
        args[0] = "THIS_IS_NOT_A_NUMBER";
        Assert.Throws<NotSupportedException>(() => Program.Main(args));
    }
}

public partial class Input_Validation
{
    private void Initialize_tariff_service()
    {
        tariffService = new TariffService();
    }

    private void Get_product_list()
    {
        Assert.Throws<NotImplementedException>(() => tariffService.getProducts(1));
    }
}
