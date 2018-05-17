using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.BarSeriesHorizontalExample
{
    public class BarSeriesHorizontalCSharp : ContentView
    {
        public BarSeriesHorizontalCSharp()
        {
            // >> chart-series-barhorizontal-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                VerticalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                HorizontalAxis = new NumericalAxis()
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
                    StripLinesVisibility = GridLineVisibility.X,
                    XStripeColor = Color.Transparent,
                    XStripeAlternativeColor = Color.FromHex("1FA9A9A9"),
                    MajorLinesVisibility = GridLineVisibility.X,
                    MajorXLineDashArray = new[] { 4.0, 2.0 },
                    MajorLineColor = Color.FromHex("D3D3D3"),
                    MajorLineThickness = 2
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-barhorizontal-csharp

            this.Content = chart;
        }
    }
}
