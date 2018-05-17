using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.GettingStartedCategory.GettingStartedExample
{
    public class ChartGettingStartedCSharp : ContentView
    {
        public ChartGettingStartedCSharp()
        {
            this.Content = CreateChart();
        }

        private static RadCartesianChart CreateChart()
        {
            // >> chart-getting-started-csharp-chart
            var chart = new RadCartesianChart
            {
                HorizontalAxis = new CategoricalAxis(),
                VerticalAxis = new NumericalAxis(),
                BindingContext = new ViewModel()
            };

            var series = new BarSeries();

            series.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data"));

            series.ValueBinding = new PropertyNameDataPointBinding { PropertyName = "Value" };
            series.CategoryBinding = new PropertyNameDataPointBinding { PropertyName = "Category" };

            chart.Series.Add(series);
            // << chart-getting-started-csharp-chart

            return chart;
        }
    }
}
