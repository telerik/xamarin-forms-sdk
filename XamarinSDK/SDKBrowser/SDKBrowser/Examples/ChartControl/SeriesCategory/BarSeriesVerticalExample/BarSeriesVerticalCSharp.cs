using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.BarSeriesVerticalExample
{
    public class BarSeriesVerticalCSharp : ContentView
    {
        public BarSeriesVerticalCSharp()
        {
            // >> chart-series-barvertical-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                VerticalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                Series =
                {
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                },
                Grid = new CartesianChartGrid
                {
                    StripLinesVisibility = GridLineVisibility.Y,
                    YStripeColor = Color.Transparent,
                    YStripeAlternativeColor = Color.FromHex("1FA9A9A9"),
                    MajorLinesVisibility = GridLineVisibility.Y,
                    MajorYLineDashArray = new[] { 4.0, 2.0 },
                    MajorLineColor = Color.FromHex("D3D3D3"),
                    MajorLineThickness = 2
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-barvertical-csharp

            this.Content = chart;
        }
    }
}
