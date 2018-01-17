using SDKBrowser.Examples.Chart.PieChart.PieChartPercentage;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class PieChartPercentageCSharp : ContentPage
    {
        public PieChartPercentageCSharp()
        {
            // >> chart-piechart-percentage-csharp
            var viewModel = new ViewModel();
            var formatter = new PercentageLabelFormatter
            {
                BindingContext = viewModel
            };

            formatter.SetBinding(PercentageLabelFormatter.TotalProperty, "Total");

            var chart = new RadPieChart
            {
                BindingContext = viewModel,
                Series =
                {
                    new PieSeries
                    {
                        ShowLabels = true,
                        RadiusFactor = 0.8,
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        LabelFormatter = formatter
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-piechart-percentage-csharp

            this.Content = chart;
        }
    }
}
