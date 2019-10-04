using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BusyIndicatorControl.HowToCategory.ListViewIntegrationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusyIndicatorWithListView : ContentView
    {
        public BusyIndicatorWithListView ()
        {
            InitializeComponent ();

            // >> busyindicator-withlistview-setvm
            this.BindingContext = new ViewModel();
            // << busyindicator-withlistview-setvm
        }
    }
}