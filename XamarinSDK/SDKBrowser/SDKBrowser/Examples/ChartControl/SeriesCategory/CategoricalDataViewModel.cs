using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory
{
    // >> chart-series-view-model-2
    public class CategoricalDataViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }

        public CategoricalDataViewModel()
        {
            this.Data = GetCategoricalData();
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "A", Value = 101 },
                new CategoricalData { Category = "B", Value = 45 },
                new CategoricalData { Category = "C", Value = 77 },
                new CategoricalData { Category = "D", Value = 15 },
                new CategoricalData { Category = "E", Value = 56 },
            };
            return data;
        }
    }
    // << chart-series-view-model-2
}
