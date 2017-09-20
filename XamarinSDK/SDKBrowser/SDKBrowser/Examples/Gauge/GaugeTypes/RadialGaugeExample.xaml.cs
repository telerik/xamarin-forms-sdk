using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Gauge
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadialGaugeExample : ContentPage
    {
        public RadialGaugeExample()
        {
            InitializeComponent();

            // >> gauge-types-radialgauge-code
            RadRadialGauge radRadialGauge = new RadRadialGauge();
            radRadialGauge.Axis = new GaugeLinearAxis() { Minimum = 0, Maximum = 200, Step = 25 };
            radRadialGauge.Indicators.Add(new GaugeNeedleIndicator() { Value = 60, Offset = 30 });
            GaugeRangesDefinition rangesDefinition = new GaugeRangesDefinition();
            rangesDefinition.Ranges.Add(new GaugeRange() { From = 0, To = 150, Color = Color.Green });
            GaugeGradientRange gradientRange = new GaugeGradientRange() { From = 150, To = 200 };
            gradientRange.GradientStops.Add(new RadGradientStop(Color.Yellow, 150));
            gradientRange.GradientStops.Add(new RadGradientStop(Color.Red, 200));
            rangesDefinition.Ranges.Add(gradientRange);
            radRadialGauge.Ranges = rangesDefinition;
            // << gauge-types-radialgauge-code
        }
    }    
}
