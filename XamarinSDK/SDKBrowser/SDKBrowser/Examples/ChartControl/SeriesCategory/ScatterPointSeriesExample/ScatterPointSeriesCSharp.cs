using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.ScatterPointSeriesExample
{
    public class ScatterPointSeriesCSharp : ContentView
    {
        public ScatterPointSeriesCSharp()
        {
            // >> chart-series-scatterpoint-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new SeriesNumericalViewModel(),
                PaletteName = PaletteNames.LightSelected,
                HorizontalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new ScatterPointSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    },
                    new ScatterPointSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-scatterpoint-csharp

            this.Content = chart;
        }
    }
}
