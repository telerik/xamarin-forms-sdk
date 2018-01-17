using SDKBrowser.Examples.Chart.Series.ScatterSplineAreaSeries;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class ScatterSplineAreaSeriesCSharp : ContentPage
    {
        public ScatterSplineAreaSeriesCSharp()
        {
            // >> chart-series-scattersplinearea-csharp
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
                    new ScatterSplineAreaSeries
                    {
                        XValueBinding = new PropertyNameDataPointBinding("XData"),
                        YValueBinding = new PropertyNameDataPointBinding("YData")
                    }
                },
                Grid = new CartesianChartGrid
                {
                    MajorLinesVisibility = GridLineVisibility.Y,
                    MajorYLineDashArray = new[] { 4.0, 2.0 },
                    MajorLineColor = Color.FromHex("D3D3D3"),
                    MajorLineThickness = 2
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-scattersplinearea-csharp

            this.Content = chart;
        }
    }
}
