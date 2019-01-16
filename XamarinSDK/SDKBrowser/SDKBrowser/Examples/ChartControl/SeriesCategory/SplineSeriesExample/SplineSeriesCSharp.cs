using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.SplineSeriesExample
{
    public class SplineSeriesCSharp : ContentView
    {
        public SplineSeriesCSharp()
        {
            // >> chart-series-spline-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new CategoricalDataViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    PlotMode = AxisPlotMode.OnTicks
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new SplineSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-spline-csharp

            this.Content = chart;
        }
    }
}
