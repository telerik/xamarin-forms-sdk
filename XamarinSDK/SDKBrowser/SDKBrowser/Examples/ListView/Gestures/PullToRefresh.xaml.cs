using System.Linq;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class PullToRefresh : ContentPage
    {

        public PullToRefresh()
        {
            InitializeComponent();
            // >> listview-gestures-pulltorefresh-source
            listView.ItemsSource = Enumerable.Range(0, this.count);
            // << listview-gestures-pulltorefresh-source
        }

        // >> listview-gestures-pulltorefresh-event
        private int count = 10;

        private async void RefreshRequested(object sender, PullToRefreshRequestedEventArgs e)
        {
            await Task.Delay(3000);
            listView.ItemsSource = Enumerable.Range(this.count, 10);
            this.count += 10;
            listView.EndRefresh();
        }
        // << listview-gestures-pulltorefresh-event
    }
}