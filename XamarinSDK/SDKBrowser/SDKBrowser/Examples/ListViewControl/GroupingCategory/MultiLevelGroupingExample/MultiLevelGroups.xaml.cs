using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.MultiLevelGroupingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiLevelGroups : ContentView
    {
        public MultiLevelGroups()
        {
            InitializeComponent();
            listView.BindingContext = new ViewModel();
        }
    }
}