using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.CustomSuggestionItemExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSuggestionItem : ContentView
    {
        public CustomSuggestionItem()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}