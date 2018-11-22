using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.TrackballSeriesExample
{
    // >> chart-track-ball-behavior-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data1 { get; set; }
        public ObservableCollection<CategoricalData> Data2 { get; set; }

        public ViewModel()
        {
            this.Data1 = GetCategoricalData1();
            this.Data2 = GetCategoricalData2();
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData1()
        {
            var data = new ObservableCollection<CategoricalData>  {
            new CategoricalData { Category = "Greenings", Value = 52 },
            new CategoricalData { Category = "Perfecto", Value = 60 },
            new CategoricalData { Category = "NearBy", Value = 77 },
            new CategoricalData { Category = "Family", Value = 50 },
            new CategoricalData { Category = "Fresh", Value = 56 },
        };
            return data;
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData2()
        {
            var data = new ObservableCollection<CategoricalData>  {
            new CategoricalData { Category = "Greenings", Value = 33 },
            new CategoricalData { Category = "Perfecto", Value = 88 },
            new CategoricalData { Category = "NearBy", Value = 61 },
            new CategoricalData { Category = "Family", Value = 94 },
            new CategoricalData { Category = "Fresh", Value = 72 },
        };
            return data;
        }
    }
    // << chart-track-ball-behavior-view-model
}
