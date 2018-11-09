using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.CustomPaletteExample
{
    // >> chart-customization-custompalette-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.Data1 = GetCategoricalData1();
            this.Data2 = GetCategoricalData2();
            this.Data3 = GetCategoricalData3();
        }

        public ObservableCollection<CategoricalData> Data1 { get; set; }

        public ObservableCollection<CategoricalData> Data2 { get; set; }

        public ObservableCollection<CategoricalData> Data3 { get; set; }

        private static ObservableCollection<CategoricalData> GetCategoricalData1()
        {
            var data = new ObservableCollection<CategoricalData>  {
                new CategoricalData { Category = "A", Value = 0.63 },
                new CategoricalData { Category = "B", Value = 0.85 },
                new CategoricalData { Category = "C", Value = 1.05 },
                new CategoricalData { Category = "D", Value = 0.96 },
                new CategoricalData { Category = "E", Value = 1.1 },
            };
            return data;
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData2()
        {
            var data = new ObservableCollection<CategoricalData>  {
                new CategoricalData { Category = "A", Value = 0.23 },
                new CategoricalData { Category = "B", Value = 0.35 },
                new CategoricalData { Category = "C", Value = 0.55 },
                new CategoricalData { Category = "D", Value = 0.66 },
                new CategoricalData { Category = "E", Value = 0.77 },
            };
            return data;
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData3()
        {
            var data = new ObservableCollection<CategoricalData>  {
                new CategoricalData { Category = "A", Value = 1.63 },
                new CategoricalData { Category = "B", Value = 1.85 },
                new CategoricalData { Category = "C", Value = 2.05 },
                new CategoricalData { Category = "D", Value = 1.96 },
                new CategoricalData { Category = "E", Value = 1.78 },
            };
            return data;
        }
    }
    // << chart-customization-custompalette-viewmodel
}
