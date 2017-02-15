using SDKBrowser.Examples.ListView.LoadOnDemand.LoadOnDemandCustomizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class LoadOnDemandCustomizations : ContentPage
    {
        public LoadOnDemandCustomizations()
        {
            InitializeComponent();

            this.BindingContext = new ListViewModel();
        }
    }
}
