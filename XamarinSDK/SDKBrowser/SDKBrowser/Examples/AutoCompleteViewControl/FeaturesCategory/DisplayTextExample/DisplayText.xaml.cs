using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.DisplayTextExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayText : ContentView
    {
        public DisplayText ()
        {
            InitializeComponent ();
            this.BindingContext = new ViewModel();

            this.autoCompleteView.AutomationId = "plainModeAutoCompleteView";
            this.radAutoCompleteView.AutomationId = "tokensModeAutoCompleteView";
        }
    }
}