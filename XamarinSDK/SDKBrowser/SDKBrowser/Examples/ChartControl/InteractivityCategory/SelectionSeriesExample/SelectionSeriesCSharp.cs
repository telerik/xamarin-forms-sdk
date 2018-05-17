using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.SelectionSeriesExample
{
    public class SelectionSeriesCSharp : ContentView
    {
        public SelectionSeriesCSharp()
        {
            // >> chart-interactivity-selectionseries-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                PaletteName = PaletteNames.Light,
                SelectionPaletteName = PaletteNames.LightSelected,
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack,
                        StackGroupKey = 1,
                        AllowSelect = true
                    },
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack,
                        StackGroupKey = 1,
                        AllowSelect = true
                    }
                },
                Behaviors =
                {
                    new ChartSelectionBehavior
                    {
                        DataPointSelectionMode = ChartSelectionMode.Single,
                        SeriesSelectionMode = ChartSelectionMode.None
                    }
                },
                Grid = new CartesianChartGrid
                {
                    StripLinesVisibility = GridLineVisibility.Y,
                    YStripeColor = Color.Transparent,
                    YStripeAlternativeColor = Color.FromHex("1FA9A9A9"),
                    MajorLinesVisibility = GridLineVisibility.Y,
                    MajorYLineDashArray = new[] { 4.0, 2.0 },
                    MajorLineColor = Color.FromHex("D3D3D3"),
                    MajorLineThickness = 2
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-interactivity-selectionseries-csharp

            this.Content = chart;
        }
    }
}
