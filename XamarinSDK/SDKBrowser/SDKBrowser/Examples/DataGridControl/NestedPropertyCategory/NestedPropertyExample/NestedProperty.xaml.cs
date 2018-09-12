using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.NestedPropertyCategory.NestedPropertyExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NestedProperty : ContentView
    {
        public NestedProperty ()
        {
            InitializeComponent ();
            
            this.BindingContext = new ViewModel();
        }
	}
}