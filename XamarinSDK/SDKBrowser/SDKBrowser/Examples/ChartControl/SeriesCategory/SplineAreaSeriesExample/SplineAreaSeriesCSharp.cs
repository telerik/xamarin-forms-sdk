using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.SplineAreaSeriesExample
{
    public class SplineAreaSeriesCSharp : ContentView
    {
        public SplineAreaSeriesCSharp()
        {
            // >> chart-series-splinearea-csharp
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
                    new SplineAreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-splinearea-csharp

            this.Content = chart;
        }
    }
}
