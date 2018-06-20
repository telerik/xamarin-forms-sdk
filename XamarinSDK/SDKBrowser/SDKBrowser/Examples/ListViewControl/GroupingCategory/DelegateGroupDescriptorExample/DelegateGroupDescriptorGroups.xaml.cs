using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.DelegateGroupDescriptorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DelegateGroupDescriptorGroups : ContentView
    {
        // >> listview-grouping-delegategroupdescriptor-settingdelegate
        public DelegateGroupDescriptorGroups()
        {
            InitializeComponent();
            listView.BindingContext = new ViewModel();

            var delegateDescriptor = new DelegateGroupDescriptor
            {
                KeyExtractor = FirstLetterKeyExtractor
            };

            listView.GroupDescriptors.Add(delegateDescriptor);
        }

        private object FirstLetterKeyExtractor(object arg)
        {
            var item = arg as City;
            return item?.Name.Substring(0, 1);
        }
        // << listview-grouping-delegategroupdescriptor-settingdelegate
    }
}