using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.ItemTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemTemplate : ContentView
    {
        public ItemTemplate()
        {
            InitializeComponent();
            // >> slideview-itemtemplate-setviewmodel
            slideView.BindingContext = new ViewModel();
            // << slideview-itemtemplate-setviewmodel
        }
    }
}