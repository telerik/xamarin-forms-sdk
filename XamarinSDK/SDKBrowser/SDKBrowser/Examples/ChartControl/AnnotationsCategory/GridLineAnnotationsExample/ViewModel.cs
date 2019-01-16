using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.ChartControl.AnnotationsCategory.GridLineAnnotationsExample
{
    // >> chart-annotations-grid-line-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }
        public double Threshold { get; set; }

        public ViewModel()
        {
            this.Data = GetCategoricalData();
            this.Threshold = this.Data.Average(data => data.Value);
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "Greenings", Value = 21 },
                new CategoricalData { Category = "Perfecto", Value = 18 },
                new CategoricalData { Category = "NearBy", Value = 44 },
                new CategoricalData { Category = "Family", Value = 77 },
                new CategoricalData { Category = "Fresh", Value = 34 },
            };
            return data;
        }
    }
    // << chart-annotations-grid-line-view-model
}
