using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.StylingCategory.DataGridStylingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataGridStyling : ContentView
    {
        public DataGridStyling ()
        {
            InitializeComponent ();

            DataGrid.ItemsSource = new List<Data>
            {
               new Data { Country = "India", Capital = "New Delhi"},
               new Data { Country = "South Africa", Capital = "Cape Town"},
               new Data { Country = "Nigeria", Capital = "Abuja" },
               new Data { Country = "Singapore", Capital = "Singapore" }
            };
        }
	}
}