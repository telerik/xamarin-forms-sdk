using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Gauge
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalGaugeExample : ContentPage
    {
        public VerticalGaugeExample()
        {
            InitializeComponent();

            // >> gauge-types-verticalgauge-code
            RadVerticalGauge radVerticalGauge = new RadVerticalGauge();
            radVerticalGauge.Axis = new GaugeLinearAxis() { Minimum = 0, Maximum = 200, Step = 25 };
            radVerticalGauge.Indicators.Add(new GaugeShapeIndicator() { Value = 90 });
            GaugeRangesDefinition rangesDefinition = new GaugeRangesDefinition();
            rangesDefinition.Ranges.Add(new GaugeRange() { From = 0, To = 150, Color = Color.Green });
            GaugeGradientRange gradientRange = new GaugeGradientRange() { From = 150, To = 200 };
            gradientRange.GradientStops.Add(new RadGradientStop(Color.Yellow, 150));
            gradientRange.GradientStops.Add(new RadGradientStop(Color.Red, 200));
            rangesDefinition.Ranges.Add(gradientRange);
            radVerticalGauge.Ranges = rangesDefinition;
            // << gauge-types-verticalgauge-code
        }
    }    
}
