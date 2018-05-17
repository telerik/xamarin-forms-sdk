using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace SDKBrowser.Examples.GaugeControl.GettingStartedCategory.GettingStartedExample
{
    public class GaugeGettingStartedCSharp : ContentView
    {
        public GaugeGettingStartedCSharp()
        {
            this.Content = CreateRadialGauge();
        }

        private static RadRadialGauge CreateRadialGauge()
        {
            // >> gauge-getting-started-csharp
            RadRadialGauge gauge = new RadRadialGauge();
            gauge.Axis = new GaugeLinearAxis { Minimum = 0, Maximum = 200, Step = 25 };
            gauge.Indicators.Add(new GaugeNeedleIndicator { Value = 60, Offset = 30, });
            gauge.Indicators.Add(new GaugeShapeIndicator { Value = 80 });
            gauge.Ranges.Ranges.Add(new GaugeRange { From = 0, To = 150, Color = Color.Green });
            GaugeGradientRange gradientRange = new GaugeGradientRange { From = 150, To = 200 };
            gradientRange.GradientStops.Add(new RadGradientStop { Color = Color.Yellow, Offset = 150 });
            gradientRange.GradientStops.Add(new RadGradientStop { Color = Color.Red, Offset = 200 });
            gauge.Ranges.Ranges.Add(gradientRange);
            // << gauge-getting-started-csharp

            return gauge;
        }
    }
}
