using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.ScatterSplineSeriesExample
{
    public class ScatterSplineSeriesCSharp : ContentView
    {
        public ScatterSplineSeriesCSharp()
        {
            // >> chart-series-scatterspline-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new SeriesNumericalViewModel(),
                HorizontalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new ScatterSplineSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    },
                    new ScatterSplineSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-scatterspline-csharp

            this.Content = chart;
        }
    }
}
