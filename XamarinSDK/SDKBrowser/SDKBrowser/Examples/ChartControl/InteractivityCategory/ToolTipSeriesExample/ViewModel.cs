using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.ToolTipSeriesExample
{
    // >> chart-tool-tip-behavior-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }

        public ViewModel()
        {
            this.Data = GetCategoricalData();
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
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
    }
    // << chart-tool-tip-behavior-view-model
}
