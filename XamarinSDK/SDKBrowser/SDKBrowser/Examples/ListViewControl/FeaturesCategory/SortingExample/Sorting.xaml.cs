using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.SortingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sorting : ContentView
    {
        // >> listview-features-sorting-agesort
        public Sorting()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
            listView.SortDescriptors.Add(new Telerik.XamarinForms.DataControls.ListView.PropertySortDescriptor { PropertyName = "Age", SortOrder = SortOrder.Ascending });
        }
        // << listview-features-sorting-agesort
    }
}