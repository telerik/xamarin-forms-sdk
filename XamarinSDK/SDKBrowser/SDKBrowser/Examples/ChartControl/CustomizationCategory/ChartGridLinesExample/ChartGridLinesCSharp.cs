using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.ChartGridLinesExample
{
    public class ChartGridLinesCSharp : ContentView
    {
        public ChartGridLinesCSharp()
        {
            // >> chart-customization-gridlines-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                VerticalAxis = new NumericalAxis(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                Series =
                {
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                },
                Grid = new CartesianChartGrid
                {
                    StripLinesVisibility = GridLineVisibility.None,
                    MajorLinesVisibility = GridLineVisibility.XY,
                    MajorLineColor = Color.Gray,
                    MajorLineThickness = 1
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-customization-gridlines-csharp

            this.Content = chart;
        }
    }
}
