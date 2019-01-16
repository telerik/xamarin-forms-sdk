using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.BarSeriesVerticalExample
{
    public class BarSeriesVerticalCSharp : ContentView
    {
        public BarSeriesVerticalCSharp()
        {
            // >> chart-series-barvertical-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new CategoricalDataViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                VerticalAxis = new NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                Series =
                {
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-series-barvertical-csharp

            this.Content = chart;
        }
    }
}
