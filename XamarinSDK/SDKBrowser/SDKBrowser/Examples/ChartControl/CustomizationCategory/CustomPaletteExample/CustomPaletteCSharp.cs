using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.CustomPaletteExample
{
    public class CustomPaletteCSharp : ContentView
    {
        public CustomPaletteCSharp()
        {
            // >> chart-customization-custompalette-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                VerticalAxis = new NumericalAxis(),
                HorizontalAxis = new CategoricalAxis
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine
                },
                Series =
                {
                    new BarSeries
                    {
                        CombineMode = ChartSeriesCombineMode.Cluster,
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    },
                    new BarSeries
                    {
                        CombineMode = ChartSeriesCombineMode.Cluster,
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    },
                    new BarSeries
                    {
                        CombineMode = ChartSeriesCombineMode.Cluster,
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    },
                },
                Palette = new ChartPalette
                {
                    Entries =
                    {
                        new PaletteEntry(Color.FromHex("#4FB6E7"), Color.FromHex("#4FB6E7")),
                        new PaletteEntry(Color.FromHex("#A666CE"), Color.FromHex("#A666CE")),
                        new PaletteEntry(Color.FromHex("#9DCC00"), Color.FromHex("#9DCC00"))
                    }
                }, 
                SelectionPalette = new ChartPalette
                {
                    Entries =
                    {
                        new PaletteEntry(Color.FromHex("#4FB6E7"), Color.FromHex("#4D4D4D")),
                        new PaletteEntry(Color.FromHex("#A666CE"), Color.FromHex("#4D4D4D")),
                        new PaletteEntry(Color.FromHex("#9DCC00"), Color.FromHex("#4D4D4D"))
                    }
                }
            };

            chart.ChartBehaviors.Add(new ChartSelectionBehavior { DataPointSelectionMode = ChartSelectionMode.None, SeriesSelectionMode = ChartSelectionMode.Single});
            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            chart.Series[2].SetBinding(ChartSeries.ItemsSourceProperty, "Data3");
            // << chart-customization-custompalette-csharp

            this.Content = chart;
        }
    }
}
