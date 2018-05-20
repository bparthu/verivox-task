using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;



[Label("FEATURE_2")]
[FeatureDescription(
@"Suggests products based on customer's yearly energy consumption")]
public partial class Tariff_Service
{
    

    [Label("SCENARIO-1")]
    [Scenario]
    public void Validate_products_for_3500_kWh()
    {
        Runner.RunScenario(
            Given_the_yearly_energy_consumption_at_3500_kWh_per_year,     
            Order_of_product_list_should_be_ProductB_and_then_ProductA,
            ProductB_is_cheaper_with_an_annual_estimate_as_800_Euro,
            ProductA_should_have_annual_estimate_as_830_Euro);
    }

    [Label("SCENARIO-2")]
    [Scenario]
    public void Validate_products_for_4500_kWh()
    {
        Runner.RunScenario(
            Given_the_yearly_energy_consumption_at_4500_kWh_per_year,
            Order_of_product_list_should_be_ProductB_and_then_ProductA,
            ProductB_is_cheaper_with_an_annual_estimate_as_950_Euro,
            ProductA_should_have_annual_estimate_as_1050_Euro);
    }

    [Label("SCENARIO-3")]
    [Scenario]
    public void Validate_products_for_6000_kWh()
    {
        Runner.RunScenario(
            Given_the_yearly_energy_consumption_at_6000_kWh_per_year,
            Order_of_product_list_should_be_ProductA_and_then_ProductB,
            ProductA_is_cheaper_with_an_annual_estimate_as_1380_Euro,
            ProductB_should_have_annual_estimate_as_1400_Euro);
    }

    [Label("SCENARIO-4")]
    [Scenario]
    public void Validate_products_for_0_kWh()
    {
        Runner.RunScenario(
            Given_the_yearly_energy_consumption_at_0_kWh_per_year,
            Order_of_product_list_should_be_ProductA_and_then_ProductB,
            ProductA_is_cheaper_with_an_annual_estimate_as_60_Euro,
            ProductB_should_have_annual_estimate_as_800_Euro);
    }


}
