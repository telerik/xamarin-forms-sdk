using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.ScatterSplineAreaSeriesExample
{
    public class ScatterSplineAreaSeriesCSharp : ContentView
    {
        public ScatterSplineAreaSeriesCSharp()
        {
            // >> chart-series-scattersplinearea-csharp
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
                    new ScatterSplineAreaSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-scattersplinearea-csharp

            this.Content = chart;
        }
    }
}
