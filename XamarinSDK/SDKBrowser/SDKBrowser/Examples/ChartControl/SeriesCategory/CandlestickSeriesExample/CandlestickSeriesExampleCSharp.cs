using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.CandlestickSeriesExample
{
    public class CandlestickSeriesExampleCSharp : ContentView
    {
        public CandlestickSeriesExampleCSharp()
        {
            // >> chart-series-candlestick-csharp
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
                    new CandlestickSeries
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
            // << chart-series-candlestick-csharp
            this.Content = chart;
        }
    }
}