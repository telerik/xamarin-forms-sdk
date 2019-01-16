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
                BindingContext = new SeriesCategoricalViewModel(),
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
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-stackbarhorizontal-csharp

            this.Content = chart;
        }
    }
}
