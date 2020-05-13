using Telerik.XamarinForms.Common.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.GroupingCategory.DelegateGroupDescriptorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DelegateGroupDescriptorGroups : ContentView
    {
        public DelegateGroupDescriptorGroups()
        {
            InitializeComponent();
            
            this.BindingContext = new ViewModel();

            // >> datagrid-grouping-delegategroupdescriptor
            this.dataGrid.GroupDescriptors.Add(new DelegateGroupDescriptor() { KeyLookup = new CustomIKeyLookup() });
            // << datagrid-grouping-delegategroupdescriptor
        }
    }

    // >> datagrid-grouping-delegategroupdescriptor-lookup
    class CustomIKeyLookup : Telerik.XamarinForms.Common.Data.IKeyLookup
    {
        public object GetKey(object instance)
        {
            var item = instance as Person;
            return item?.Name[0];
        }
    }
    // << datagrid-grouping-delegategroupdescriptor-lookup
}