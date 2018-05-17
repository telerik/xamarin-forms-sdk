using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.CustomPaletteExample
{
    public class ViewModel
    {
        public ObservableCollection<CategoricalData> Data1 { get; private set; }
        public ObservableCollection<CategoricalData> Data2 { get; private set; }
        public ObservableCollection<CategoricalData> Data3 { get; private set; }

        public ViewModel()
        {
            this.Data1 = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
            this.Data2 = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData2());
            this.Data3 = new ObservableCollection<CategoricalData>(DataProvider.GetCategoricalData());
        }
    }
}
