using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.StackBarSeriesHorizontalExample
{
    public class StackBarSeriesHorizontalCSharp : ContentView
    {
        public StackBarSeriesHorizontalCSharp()
        {
            // >> chart-series-stackbarhorizontal-csharp
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
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    },
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
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

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-stackbarhorizontal-csharp

            this.Content = chart;
        }
    }
}
