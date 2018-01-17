using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.Chart.Series.PlotBandAnnotations
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; private set; }
        public double StartThreshold { get; private set; }
        public double EndThreshold { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());

            var threshold = this.Data.Average(data => data.Value);

            this.StartThreshold = threshold * 0.9;
            this.EndThreshold = threshold * 1.1;
        }
    }
}
