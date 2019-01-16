using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.StackAreaSeriesExample
{
    public class StackAreaSeriesCSharp : ContentView
    {
        public StackAreaSeriesCSharp()
        {
            // >> chart-series-stackarea-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new SeriesCategoricalViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    PlotMode = AxisPlotMode.OnTicks
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new AreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    },
                    new AreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-stackarea-csharp

            this.Content = chart;
        }
    }
}
