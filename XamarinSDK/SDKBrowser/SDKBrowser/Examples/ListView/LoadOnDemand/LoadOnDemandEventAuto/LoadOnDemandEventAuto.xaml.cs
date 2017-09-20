using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class LoadOnDemandEventAuto : ContentPage
    {


        public LoadOnDemandEventAuto()
        {
            InitializeComponent();

            // >> listview-loadondemand-loadondemandeventauto-bind
            var source = new ObservableCollection<string>();
            for (int i = 0; i < 14; i++)
            {
                source.Add(string.Format("Item {0}", i));
            }
            this.listView.ItemsSource = source;
            // << listview-loadondemand-loadondemandeventauto-bind
        }

        // >> listview-loadondemand-loadondemandeventauto-event
        private int lodItemsCount = 0;

        private async void ListView_LoadOnDemand(object sender, EventArgs e)
        {
            //simulates connection latency
            await Task.Delay(4000);

            this.lodItemsCount++;
            foreach (string item in Enum.GetNames(typeof(DayOfWeek)))
            {
                (listView.ItemsSource as ObservableCollection<string>).Add(string.Format("LOD: {0} - {1}", lodItemsCount, item));
            }
            this.listView.IsLoadOnDemandActive = false;


        }
        // << listview-loadondemand-loadondemandeventauto-event
    }
}
