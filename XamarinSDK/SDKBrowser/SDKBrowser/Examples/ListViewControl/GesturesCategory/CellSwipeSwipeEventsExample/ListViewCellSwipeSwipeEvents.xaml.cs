using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.GesturesCategory.CellSwipeSwipeEventsExample
{
    public partial class ListViewCellSwipeSwipeEvents : ContentView
    {
        public ListViewCellSwipeSwipeEvents()
        {
            this.InitializeComponent();
        }

        // >> listview-gestures-cellswipe-swipeevents-swipecompleted
        void OnItemSwipeCompleted(object sender, ItemSwipeCompletedEventArgs e)
        {
            var listView = sender as RadListView;
            var item = e.Item as Mail;

            listView.EndItemSwipe();

            if (e.Offset >= 70)
            {
                item.IsUnread = false;
            }
            else if (e.Offset <= -70)
            {
                (listView.ItemsSource as ObservableCollection<Mail>).Remove(item);
            }
        }
        // << listview-gestures-cellswipe-swipeevents-swipecompleted
    }
}
