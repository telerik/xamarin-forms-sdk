using SDKBrowser.Examples.ListView.LoadOnDemand.LoadOnDemandCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class LoadOnDemandCollection: ContentPage
    {
      
        public LoadOnDemandCollection()
        {
            InitializeComponent();

            // >> listview-loadondemand-loadondemandcollection-binding
            this.BindingContext = new ListViewModel();
            // << listview-loadondemand-loadondemandcollection-binding
        }
    }

}