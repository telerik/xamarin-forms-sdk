using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.GroupingCategory.PropertyGroupDescriptorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyGroupDescriptor : ContentView
    {
        public PropertyGroupDescriptor()
        {
            InitializeComponent();

            // >> datagrid-grouping-propertygroupdescriptor-setvm
            this.BindingContext = new ViewModel();
            // << datagrid-grouping-propertygroupdescriptor-setvm
        }
    }
}