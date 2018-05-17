using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.PanZoomExample
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
