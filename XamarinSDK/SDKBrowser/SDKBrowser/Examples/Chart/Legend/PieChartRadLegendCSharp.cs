using SDKBrowser.Examples.Chart.Legend;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class PieChartRadLegendCSharp : ContentPage
    {
        public PieChartRadLegendCSharp()
        {
            this.Content = this.CreateChart();
        }

        private View CreateChart()
        {
            var container = new StackLayout();

            // >> chart-features-piechart-legend-definition-cs
            var chart = new RadPieChart
            {
                BindingContext = new ViewModel(),
                HeightRequest = 300
            };
            // >> chart-features-piechart-legendtitlebinding-cs
            var series = new PieSeries
            {
                ValueBinding = new PropertyNameDataPointBinding("Value"),
                DisplayName = "Value",
                LegendTitleBinding = new PropertyNameDataPointBinding("Category")
            };
            // << chart-features-piechart-legendtitlebinding-cs
            series.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data1"));
            chart.Series.Add(series);

            var legend = new RadLegend
            {
                LegendProvider = chart,
                HeightRequest = 200,
                LegendItemFontColor = Color.DarkGreen,
                LegendItemFontSize = 20
            };
            // << chart-features-piechart-legend-definition-cs

            container.Children.Add(chart);
            container.Children.Add(legend);

            return container;
        }
    }
}