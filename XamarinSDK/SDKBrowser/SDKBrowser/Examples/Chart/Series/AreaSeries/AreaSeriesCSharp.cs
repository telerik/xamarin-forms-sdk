using SDKBrowser.Examples.Chart.Series.AreaSeries;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class AreaSeriesCSharp : ContentPage
    {
        public AreaSeriesCSharp()
        {
            // >> chart-series-area-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
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
            // << chart-series-area-csharp

            this.Content = chart;
        }
    }
}
