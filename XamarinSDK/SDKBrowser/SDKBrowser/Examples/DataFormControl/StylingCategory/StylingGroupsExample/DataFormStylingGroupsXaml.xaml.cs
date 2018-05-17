using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.StylingCategory.StylingGroupsExample
{
    public partial class DataFormStylingGroupsXaml : ContentView
    {
        public DataFormStylingGroupsXaml()
        {
            this.InitializeComponent();
            this.BindingContext = new Customer();
        }
    }
}
