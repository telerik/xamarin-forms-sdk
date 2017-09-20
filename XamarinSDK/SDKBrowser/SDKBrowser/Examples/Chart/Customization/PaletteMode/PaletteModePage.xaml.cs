using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Chart
{
    public partial class PaletteModePage : ContentPage
    {
        public PaletteModePage()
        {
            InitializeComponent();

            this.pickerPaletteMode.Items.Add(SeriesPaletteMode.DataPoint.ToString());
            this.pickerPaletteMode.Items.Add(SeriesPaletteMode.Series.ToString());
            this.pickerPaletteMode.SelectedIndex = 0;

            var customPalette = this.CreateCustomPalette();
            this.chart.Palette = customPalette;
        }

        private ChartPalette CreateCustomPalette()
        {
            var palette = new ChartPalette();

            palette.Entries.Add(new PaletteEntry(Color.Green));
            palette.Entries.Add(new PaletteEntry(Color.HotPink));
            palette.Entries.Add(new PaletteEntry(Color.Red));
            palette.Entries.Add(new PaletteEntry(Color.Yellow));
            palette.Entries.Add(new PaletteEntry(Color.Orange));

            return palette;
        }

        private void PickerPaletteMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPaletteMode = this.pickerPaletteMode.Items[this.pickerPaletteMode.SelectedIndex];
            this.barSeries.PaletteMode = (SeriesPaletteMode) Enum.Parse(typeof(SeriesPaletteMode), selectedPaletteMode);
        }
    }
}