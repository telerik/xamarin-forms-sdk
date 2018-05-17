using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.LoadOnDemandCategory.LoadOnDemandCollectionExample
{
    public partial class LoadOnDemandCollection: ContentView
    {
      
        public LoadOnDemandCollection()
        {
            this.InitializeComponent();

            // >> listview-loadondemand-loadondemandcollection-binding
            this.BindingContext = new ListViewModel();
            // << listview-loadondemand-loadondemandcollection-binding
        }
    }

}