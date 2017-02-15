using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class ChartGettingStartedCSharp : ContentPage
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
                BindingContext = new GettingStarted.ViewModel()
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
