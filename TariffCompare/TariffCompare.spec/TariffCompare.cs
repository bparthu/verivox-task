using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;


[assembly: ConfiguredLightBddScope]
[Label("FEATURE_1")]
[FeatureDescription(
@"validates given input")]
public partial class Input_Validation
{
    [Label("SCENARIO-1")]
	[Scenario]
	public void Should_throw_argument_exception()
	{
		Runner.RunScenario(
            If_CONSUMPTION_argument_is_not_provided);
	}

    [Label("SCENARIO-2")]
    [Scenario]
    public void Should_throw_not_supported_exception()
    {
        Runner.RunScenario(
            If_CONSUMPTION_argument_contains_empty_string,
            If_CONSUMPTION_argument_contains_invalid_input);
    }

}
