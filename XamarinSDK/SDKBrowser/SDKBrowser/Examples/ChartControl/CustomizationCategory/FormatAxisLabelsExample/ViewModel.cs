using System;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.FormatAxisLabelsExample
{
    // >> chart-customization-formataxislabels-view-model
    public class ViewModel
    {
        public ObservableCollection<TemporalData> Data { get; set; }

        public ViewModel()
        {
            this.Data = GetDateTimeData(6);
        }

        private static ObservableCollection<TemporalData> GetDateTimeData(int itemsCount)
        {
            var startDate = new DateTime(2015, 03, 01);

            ObservableCollection<TemporalData> items = new ObservableCollection<TemporalData>();
            for (int i = 0; i < itemsCount; i++)
            {
                TemporalData data = new TemporalData();
                data.Date = startDate.AddDays(i);
                data.Value = Math.Sin(i);

                items.Add(data);
            }

            return items;
        }
    }
    // << chart-customization-formataxislabels-view-model
}
