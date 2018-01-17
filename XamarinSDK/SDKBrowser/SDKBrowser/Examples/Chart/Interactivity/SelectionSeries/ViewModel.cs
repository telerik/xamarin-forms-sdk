using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Series.SelectionSeries
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data1 { get; private set; }
        public ObservableCollection<CategoricalData> Data2 { get; private set; }

        public ViewModel()
        {
            this.Data1 = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
            this.Data2 = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData2());
        }
    }
}
