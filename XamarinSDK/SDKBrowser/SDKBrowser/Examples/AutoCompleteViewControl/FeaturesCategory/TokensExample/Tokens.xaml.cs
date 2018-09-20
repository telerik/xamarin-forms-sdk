using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.TokensExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tokens : ContentView
    {
        public Tokens()
        {
            InitializeComponent();

            this.BindingContext = new TokensViewModel();
        }
    }
}