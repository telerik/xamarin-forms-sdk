using SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.EditingExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.TemplatesCategory.TokenTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TokenTemplate : ContentView
    {
        public TokenTemplate()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }

        // >> remove-the-selecteditem
        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var closeLabel = sender as Label;
            if (closeLabel != null)
            {
                var item = closeLabel.BindingContext as City;
                if (item != null)
                {
                    this.comboBox.SelectedItems.Remove(item);
                }
            }
        }
        // << remove-the-selecteditem
    }
}