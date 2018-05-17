using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.PaletteModeExample
{
    public class PaletteModeCSharp : ContentView
    {
        public PaletteModeCSharp()
        {
            this.BindingContext = new ViewModel();

            // >> chart-customization-palettemode-csharp
            var chart = new RadCartesianChart
            {
                HorizontalAxis = new CategoricalAxis(),
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new BarSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                },
                Palette = new ChartPalette
                {
                    Entries =
                    {
                        new PaletteEntry(Color.Green),
                        new PaletteEntry(Color.HotPink),
                        new PaletteEntry(Color.Red),
                        new PaletteEntry(Color.Yellow),
                        new PaletteEntry(Color.Orange)
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            chart.Series[0].SetBinding(BarSeries.PaletteModeProperty, "SelectedMode");
            // << chart-customization-palettemode-csharp

            var label = new Label
            {
                TextColor = Color.Black,
                Text = "Select PaletteMode:"
            };

            var picker = new Picker
            {
                TextColor = Color.Black
            };

            picker.SetBinding(Picker.ItemsSourceProperty, "Modes");
            picker.SetBinding(Picker.SelectedItemProperty, "SelectedMode", BindingMode.TwoWay);

            var layout = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition
                    {
                        Height = new GridLength(1, GridUnitType.Star)
                    },
                    new RowDefinition
                    {
                        Height = new GridLength(0, GridUnitType.Auto)
                    },
                    new RowDefinition
                    {
                        Height = new GridLength(0, GridUnitType.Auto)
                    }
                },
                Children =
                {
                    chart,
                    label,
                    picker
                }
            };

            Grid.SetRow(chart, 0);
            Grid.SetRow(label, 1);
            Grid.SetRow(picker, 2);

            this.Content = layout;
        }
    }
}
