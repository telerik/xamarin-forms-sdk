using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.AreaSeriesExample
{
    public class AreaSeriesCSharp : ContentView
    {
        public AreaSeriesCSharp()
        {
            // >> chart-series-area-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new CategoricalViewModel(),
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
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-area-csharp

            this.Content = chart;
        }
    }
}
