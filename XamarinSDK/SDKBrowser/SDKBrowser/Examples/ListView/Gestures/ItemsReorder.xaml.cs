using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class ReorderItems : ContentPage
    {
        public ReorderItems()
        {
            InitializeComponent();

            // >> listview-gestures-reorderitems-code
            this.listView.ItemsSource = new ObservableCollection<string>()
            {
              "Check weather for London",
              "Call Brian Ingram",
              "Check the childrens' documents",
              "Take care of the dog",
              "Airplane tickets reschedule",
              "Check the trains schedule",
              "Bills due: Alissa's ballet class",
              "Weekly organic basket"
            };
            // << listview-gestures-reorderitems-code
        }
    }
}
