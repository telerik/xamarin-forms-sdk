using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.LoadOnDemandCategory.LoadOnDemandCommandExample
{
    public partial class LoadOnDemandCommand : ContentView
    {
        public LoadOnDemandCommand()
        {
            this.InitializeComponent();

            // >> listview-loadondemand-loadondemandcommand-binding
            this.BindingContext = new ListViewModel();
            // << listview-loadondemand-loadondemandcommand-binding
        }
    }
}
