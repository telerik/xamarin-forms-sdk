using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.FilteringExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Filtering : ContentView
    {
        // >> listview-features-filtering-agefilter
        public Filtering()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
            listView.FilterDescriptors.Add(new Telerik.XamarinForms.DataControls.ListView.DelegateFilterDescriptor { Filter = this.AgeFilter });
        }
        private bool AgeFilter(object arg)
        {
            var age = ((Item)arg).Age;
            return age >= 25 && age <= 35;
        }
        // << listview-features-filtering-agefilter
    }
}