using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class CustomPalettePage : ContentPage
    {
        public CustomPalettePage()
        {
            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData();

            var chart = new RadCartesianChart
            {
                VerticalAxis = new NumericalAxis(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                }
            };

            var series = new BarSeries();

            series.CombineMode = ChartSeriesCombineMode.Stack;

            series.ItemsSource = model.Data1;

            series.ValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series.CategoryBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series);

            var series1 = new BarSeries();

            series1.ItemsSource = model.Data1;

            series1.CombineMode = ChartSeriesCombineMode.Stack;

            series1.ValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series1.CategoryBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series1);

            var series2 = new BarSeries();

            series2.ItemsSource = model.Data1;

            series2.CombineMode = ChartSeriesCombineMode.Stack;

            series2.ValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series2.CategoryBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series2);

            chart.Palette = this.CreateCustomPalette();

            this.Content = chart;
        }

        private ChartPalette CreateCustomPalette()
        {
            var palette = new ChartPalette();

            palette.Entries.Add(new PaletteEntry(Color.Blue, Color.Red));
            palette.Entries.Add(new PaletteEntry(Color.Gray, Color.Yellow));

            return palette;
        }
    }
}
