using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.Chart.PieChart.PieChartPercentage
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; private set; }
        public double Total { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
            this.Total = this.Data.Sum(data => data.Value);
        }
    }
}
