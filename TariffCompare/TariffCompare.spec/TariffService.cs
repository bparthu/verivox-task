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
    public void ValidateProductOrder()
    {
        Runner.RunScenario(
            Given_the_yearly_energy_consumption_at_1000_kWh_per_year,           
            ProductA_and_ProductB_should_be_displayed_in_same_order);
    }
}
