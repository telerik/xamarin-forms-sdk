using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Series.PanZoom
{
    public class ViewModel
    {
        public ObservableCollection<TemporalData> Data { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<TemporalData>(DataProvider.GetDateTimeData2(200));
        }
    }
}
