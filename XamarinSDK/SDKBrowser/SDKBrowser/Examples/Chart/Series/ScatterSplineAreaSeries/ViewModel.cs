using System;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Series.ScatterSplineAreaSeries
{
    public class ViewModel
    {
        public ObservableCollection<NumericalData> Data { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<NumericalData>(DataProvider.GetNumericData());
        }
    }
}
