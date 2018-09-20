using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.ItemTemplateSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemTemplateSelector : ContentView
    {
        public ItemTemplateSelector()
        {
            InitializeComponent();
            // >> slideview-itemtemplateselector-setviewmodel
            this.slideView.BindingContext = new ViewModel();
            // << slideview-itemtemplateselector-setviewmodel
        }
    }
}