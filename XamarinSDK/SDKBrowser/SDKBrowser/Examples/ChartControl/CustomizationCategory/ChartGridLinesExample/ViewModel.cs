using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.ChartGridLinesExample
{
    // >> chart-customization-grid-lines-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }

        public ViewModel()
        {
            this.Data = GetCategoricalData();
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "Greenings", Value = 21 },
                new CategoricalData { Category = "Perfecto", Value = 44 },
                new CategoricalData { Category = "NearBy", Value = 39 },
                new CategoricalData { Category = "Family", Value = 11 },
                new CategoricalData { Category = "Fresh", Value = 83 },
            };
            return data;
        }
    }
    // << chart-customization-grid-lines-view-model
}
