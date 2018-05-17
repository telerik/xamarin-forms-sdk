using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.LegendCategory.CartesianChartRadLegendExample
{
    public class CartesianChartRadLegendCSharp : ContentView
    {
        public CartesianChartRadLegendCSharp()
        {
            this.Content = this.CreateChart();
        }

        private View CreateChart()
        {
            var container = new StackLayout();
            // >> chart-features-cartesianchart-legend-definition-cs
            var chart = new RadCartesianChart
            {
                HorizontalAxis = new CategoricalAxis(),
                VerticalAxis = new NumericalAxis(),
                BindingContext = new ViewModel(),
                HeightRequest = 300
            };

            var seriesData1 = new LineSeries
            {
                CategoryBinding = new PropertyNameDataPointBinding("Category"),
                ValueBinding = new PropertyNameDataPointBinding("Value"),
                DisplayName = "Data1"
            };

            seriesData1.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data1"));
            chart.Series.Add(seriesData1);

            var seriesData2 = new LineSeries
            {
                CategoryBinding = new PropertyNameDataPointBinding("Category"),
                ValueBinding = new PropertyNameDataPointBinding("Value"),
                DisplayName = "Data2"
            };

            seriesData2.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data2"));
            chart.Series.Add(seriesData2);

            var seriesData3 = new LineSeries
            {
                CategoryBinding = new PropertyNameDataPointBinding("Category"),
                ValueBinding = new PropertyNameDataPointBinding("Value"),
                DisplayName = "Data3"
            };

            seriesData3.SetBinding(ChartSeries.ItemsSourceProperty, new Binding("Data3"));
            chart.Series.Add(seriesData3);

            var legend = new RadLegend
            {
                LegendProvider = chart,
                HeightRequest = 200,
                LegendItemFontColor = Color.DarkGreen,
                Orientation = LegendOrientation.Horizontal
            };
            // << chart-features-cartesianchart-legend-definition-cs
            container.Children.Add(chart);
            container.Children.Add(legend);
            return container;
        }
    }
}
