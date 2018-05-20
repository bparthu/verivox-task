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

    private void If_CONSUMPTION_argument_contains_negative_number()
    {
        string[] args = new string[1];
        args[0] = "-1";
        Assert.Throws<NotSupportedException>(() => Program.Main(args));
    }

    private void If_CONSUMPTION_argument_contains_number_more_than_2147483647()
    {
        string[] args = new string[1];
        args[0] = "2147483648";
        Assert.Throws<NotSupportedException>(() => Program.Main(args));
    }

    

}
