using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.BarSeriesHorizontalExample
{
    public class BarSeriesHorizontalCSharp : ContentView
    {
        public BarSeriesHorizontalCSharp()
        {
            // >> chart-series-barhorizontal-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new CategoricalDataViewModel(),
                VerticalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                HorizontalAxis = new NumericalAxis()
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
            // << chart-series-barhorizontal-csharp

            this.Content = chart;
        }
    }
}
