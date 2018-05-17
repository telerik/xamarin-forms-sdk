using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.FormatAxisLabelsExample
{
    public class ViewModel
    {
        public ObservableCollection<TemporalData> Data { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<TemporalData>(DataProvider.GetDateTimeData(6));
        }
    }
}
