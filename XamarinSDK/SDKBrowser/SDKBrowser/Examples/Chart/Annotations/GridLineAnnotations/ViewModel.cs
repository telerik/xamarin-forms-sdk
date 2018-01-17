using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.Chart.Series.GridLineAnnotations
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; private set; }
        public double Threshold { get; private set; }
        public double StartThreshold { get; private set; }
        public double EndThreshold { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
            this.Threshold = this.Data.Average(data => data.Value);
            this.StartThreshold = this.Threshold * 0.95;
            this.EndThreshold = this.Threshold * 1.05;
        }
    }
}
