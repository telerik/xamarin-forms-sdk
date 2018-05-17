using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.LoadOnDemandCategory.LoadOnDemandEventManualExample
{
    public partial class LoadOnDemandEventManual : ContentView
    {
        public LoadOnDemandEventManual()
        {
            this.InitializeComponent();

            // >> listview-loadondemand-loadondemandeventmanual-bind
            var source = new ObservableCollection<string>();
            for (int i = 0; i < 14; i++)
            {
                source.Add(string.Format("Item {0}", i));
            }
            this.listView.ItemsSource = source;
            // << listview-loadondemand-loadondemandeventmanual-bind
        }

        // >> listview-loadondemand-loadondemandeventmanual-event
        private int lodTriggerCount = 0;

        private void ListView_LoadOnDemand(object sender, EventArgs e)
        {
            this.lodTriggerCount++;
            foreach (string item in Enum.GetNames(typeof(DayOfWeek)))
            {
                (listView.ItemsSource as ObservableCollection<string>).Add(string.Format("LOD: {0} - {1}", lodTriggerCount, item));
            }
        }
        // << listview-loadondemand-loadondemandeventmanual-event
    }
}
