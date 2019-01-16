using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.ReorderInGroupedListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReorderItemsInGroupedListView : ContentView
    {
        public ReorderItemsInGroupedListView()
        {
            InitializeComponent();
            // >> listview-grouping-reorderitems-setviewmodel
            this.BindingContext = new ViewModel();
            // << listview-grouping-reorderitems-setviewmodel
        }
    }
}