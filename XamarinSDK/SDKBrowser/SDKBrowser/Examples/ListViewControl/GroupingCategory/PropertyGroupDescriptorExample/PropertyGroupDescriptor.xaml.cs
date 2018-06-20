using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.PropertyGroupDescriptorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyGroupDescriptor : ContentView
    {
        public PropertyGroupDescriptor()
        {
            InitializeComponent();
            // >> listview-grouping-propertygroupdescriptor-settingviewmodel
            listView.BindingContext = new ViewModel();
            // << listview-grouping-propertygroupdescriptor-settingviewmodel
        }
    }
}