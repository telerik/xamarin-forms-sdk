using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.ScatterAreaSeriesExample
{
    public class ScatterAreaSeriesCSharp : ContentView
    {
        public ScatterAreaSeriesCSharp()
        {
            // >> chart-series-scatterarea-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new NumericalViewModel(),
                HorizontalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new ScatterAreaSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-scatterarea-csharp

            this.Content = chart;
        }
    }
}
