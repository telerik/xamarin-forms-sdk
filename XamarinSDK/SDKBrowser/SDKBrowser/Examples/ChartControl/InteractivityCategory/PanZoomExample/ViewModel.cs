using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.PanZoomExample
{
    // >> chart-pan-and-zoom-behavior-view-model
    public class ViewModel
    {
        public ObservableCollection<TemporalData> Data { get; set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<TemporalData>(GetDateTimeData(200));
        }

        private static List<TemporalData> GetDateTimeData(int itemsCount)
        {
            var startDate = new DateTime(2015, 03, 01);

            List<TemporalData> items = new List<TemporalData>();
            for (int i = 0; i < itemsCount; i++)
            {
                TemporalData data = new TemporalData();
                data.Date = startDate.AddDays(i);

                if (i % 2 == 0)
                {
                    data.Value = i + 5;
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        data.Value = i - 15;
                    }
                }

                items.Add(data);
            }

            return items;
        }
    }
    // << chart-pan-and-zoom-behavior-view-model
}
