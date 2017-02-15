using SDKBrowser.Examples.DataForm.Groups;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormGroups : ContentPage
    {
        public DataFormGroups()
        {
            InitializeComponent();

            this.dataForm.Source = new Customer();
        }
    }
}
