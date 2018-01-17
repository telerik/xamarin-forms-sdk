using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.NumericInput
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bindings : ContentPage
    {
        public Bindings()
        {
            InitializeComponent();
            this.BindingContext = new Features.ViewModel();
        }
    }
}