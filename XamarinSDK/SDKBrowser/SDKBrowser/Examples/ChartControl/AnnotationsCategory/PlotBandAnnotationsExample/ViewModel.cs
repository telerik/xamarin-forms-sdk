using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.ChartControl.AnnotationsCategory.PlotBandAnnotationsExample
{
    // >> chart-annotations-plot-band-view-model
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; set; }
        public double StartThreshold { get; private set; }
        public double EndThreshold { get; private set; }

        public ViewModel()
        {
            this.Data = GetCategoricalData();
            var threshold = this.Data.Average(data => data.Value);
            this.StartThreshold = threshold * 0.9;
            this.EndThreshold = threshold * 1.1;
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "Greenings", Value = 66 },
                new CategoricalData { Category = "Perfecto", Value = 19 },
                new CategoricalData { Category = "NearBy", Value = 92 },
                new CategoricalData { Category = "Family", Value = 23 },
                new CategoricalData { Category = "Fresh", Value = 56 },
            };
            return data;
        }
    }
    // << chart-annotations-plot-band-view-model
}
