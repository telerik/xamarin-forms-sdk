using SDKBrowser.Examples.DataForm.Styling.Groups;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormStylingGroupsXaml : ContentPage
    {
        public DataFormStylingGroupsXaml()
        {
            InitializeComponent();
            this.BindingContext = new Customer();
        }
    }
}
