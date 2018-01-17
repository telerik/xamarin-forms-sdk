using SDKBrowser.Examples.Chart.Series.ScatterLineSeries;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class ScatterLineSeriesCSharp : ContentPage
    {
        public ScatterLineSeriesCSharp()
        {
            // >> chart-series-scatterline-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                HorizontalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new ScatterLineSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    },
                    new ScatterLineSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                },
                Grid = new CartesianChartGrid
                {
                    MajorLinesVisibility = GridLineVisibility.XY,
                    MajorXLineDashArray = new[] { 4.0, 2.0 },
                    MajorYLineDashArray = new[] { 4.0, 2.0 },
                    MajorLineColor = Color.FromHex("D3D3D3"),
                    MajorLineThickness = 2
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-scatterline-csharp

            this.Content = chart;
        }
    }
}
