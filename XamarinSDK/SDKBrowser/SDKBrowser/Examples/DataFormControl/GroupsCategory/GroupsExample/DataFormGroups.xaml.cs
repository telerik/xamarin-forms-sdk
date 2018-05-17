using SDKBrowser.Examples.DataFormControl.GroupsCategory;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.GroupsCategory.GroupsExample
{
    public partial class DataFormGroups : ContentView
    {
        public DataFormGroups()
        {
            this.InitializeComponent();

            this.dataForm.Source = new Customer();
        }
    }
}
