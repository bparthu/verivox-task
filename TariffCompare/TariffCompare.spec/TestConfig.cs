using LightBDD.Core.Configuration;
using LightBDD.Framework.Reporting.Configuration;
using LightBDD.Framework.Reporting.Formatters;
using LightBDD.XUnit2;


class ConfiguredLightBddScopeAttribute : LightBddScopeAttribute
{
    protected override void OnConfigure(LightBddConfiguration configuration)
    {
        // some example customization of report writers
        configuration
            .ReportWritersConfiguration()
            .AddFileWriter<HtmlReportFormatter>("..\\..\\..\\Reports\\FeaturesReport.html");
    }

    protected override void OnSetUp()
    {
        // additional code that has to be run before any LightBDD tests
    }

    protected override void OnTearDown()
    {
        // additional code that has to be run after all LightBDD tests
    }
}
