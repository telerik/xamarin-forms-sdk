using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.StackBarSeriesVerticalExample
{
    public class StackBarSeriesVerticalCSharp : ContentView
    {
        public StackBarSeriesVerticalCSharp()
        {
            // >> chart-series-stackbarvertical-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new SeriesCategoricalViewModel(),
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
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    },
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-stackbarvertical-csharp

            this.Content = chart;
        }
    }
}
