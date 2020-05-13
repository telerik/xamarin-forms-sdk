using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.FilteringCategory.FilterTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterTemplate : ContentView
    {
        public FilterTemplate()
        {
            InitializeComponent();

            this.BindingContext = new FilteringViewModel();
        }
    }
}