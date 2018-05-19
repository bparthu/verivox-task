using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;


    [assembly: ConfiguredLightBddScope]
    [Label("FEATURE_1")]
	[FeatureDescription(
@"Suggests products based on yearly energy consumption")]
	public partial class Tariff_Compare
	{
        [Label("SCENARIO-1")]
		[Scenario]
		public void Should_validate_command_line_arguments()
		{
			Runner.RunScenario(
                Throws_argument_exception);
		}

		[Label("SCENARIO-2")]
		[Scenario]
		public void Should_throw_not_implemented_exception()
		{
			Runner.RunScenario(
				Initialize_tariff_service,
				Get_product_list);
		}
	}
