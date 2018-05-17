using System;
using System.Collections.Generic;
using SDKBrowser.ViewModels;
using Telerik.XamarinForms.Chart;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.PaletteModeExample
{
    public class ViewModel : ViewModelBase
    {
        private SeriesPaletteMode selectedMode;

        public IEnumerable<CategoricalData> Data { get; private set; }
        public IEnumerable<SeriesPaletteMode> Modes { get; private set; }

        public SeriesPaletteMode SelectedMode
        {
            get
            {
                return this.selectedMode;
            }
            set
            {
                if (this.selectedMode != value)
                {
                    this.selectedMode = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public ViewModel()
        {
            this.Data = new[]
            {
                new CategoricalData { Category = "A", Value = 0.69 },
                new CategoricalData { Category = "B", Value = 0.85 },
                new CategoricalData { Category = "C", Value = 1.05 },
                new CategoricalData { Category = "D", Value = 0.96 },
                new CategoricalData { Category = "E", Value = 0.78 },
            };

            this.Modes = (IEnumerable<SeriesPaletteMode>)
                Enum.GetValues(typeof(SeriesPaletteMode));
            this.SelectedMode = SeriesPaletteMode.DataPoint;
        }
    }
}
