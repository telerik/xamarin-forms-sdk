using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.OhlcSeriesExample
{
    public class OhlcSeriesExampleCSharp : ContentView
    {
        public OhlcSeriesExampleCSharp()
        {
            // >> chart-series-ohlc-csharp
            var chart = new RadCartesianChart
            {
                BackgroundColor = Color.White,
                BindingContext = new ViewModel(),
                HorizontalAxis = new DateTimeContinuousAxis()
                {
                    LabelFitMode = AxisLabelFitMode.Rotate,
                    PlotMode = AxisPlotMode.BetweenTicks,
                    MajorStepUnit = TimeInterval.Month,
                    LabelFormat = "MMM"
                },
                VerticalAxis = new NumericalAxis()
                {
                    LineColor = Color.FromHex("#A9A9A9"),
                    MajorTickBackgroundColor = Color.FromHex("#A9A9A9")
                },
                Series =
                {
                    new OhlcSeries
                    {
                       CategoryBinding = new PropertyNameDataPointBinding("Category"),
                       OpenBinding = new PropertyNameDataPointBinding("Open"),
                       HighBinding = new PropertyNameDataPointBinding("High"),
                       LowBinding = new PropertyNameDataPointBinding("Low"),
                       CloseBinding = new PropertyNameDataPointBinding("Close")
                    }
                },
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "SeriesData");
            // << chart-series-ohlc-csharp
            this.Content = chart;
        }
    }
}