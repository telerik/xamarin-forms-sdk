using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Series.ScatterAreaSeries
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
