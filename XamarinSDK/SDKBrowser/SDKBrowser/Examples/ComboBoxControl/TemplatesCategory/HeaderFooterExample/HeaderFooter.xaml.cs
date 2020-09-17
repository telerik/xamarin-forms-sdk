using SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.EditingExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.TemplatesCategory.HeaderFooterExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderFooter : ContentView
    {
        ViewModel vm;
        public HeaderFooter()
        {
            InitializeComponent();
            this.vm = new ViewModel();
            this.BindingContext = vm;
        }
        // >> combobox-footer-template-button-clicked
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.vm.Items.Add(new City { Name = "Sofia", Population = 1243000 });
        }
        // << combobox-footer-template-button-clicked
    }
}