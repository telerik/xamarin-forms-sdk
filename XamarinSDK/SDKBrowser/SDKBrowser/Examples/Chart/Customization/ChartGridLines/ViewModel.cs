using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Customization.ChartGridLines
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
        }
    }
}
