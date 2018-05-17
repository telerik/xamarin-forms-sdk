using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.PieChartCategory.PieChartExample
{
    public class PieChartCSharp : ContentView
    {
        public PieChartCSharp()
        {
            // >> chart-piechart-csharp
            var chart = new RadPieChart
            {
                BindingContext = new ViewModel(),
                Series =
                {
                    new PieSeries
                    {
                        ShowLabels = true,
                        RadiusFactor = 0.8,
                        ValueBinding = new PropertyNameDataPointBinding("Value")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-piechart-csharp

            this.Content = chart;
        }
    }
}
