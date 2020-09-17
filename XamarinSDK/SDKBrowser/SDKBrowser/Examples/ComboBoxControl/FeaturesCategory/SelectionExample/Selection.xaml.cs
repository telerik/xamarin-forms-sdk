using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SelectionExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selection : ContentView
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void RadComboBox_SelectionChanged(object sender, Telerik.XamarinForms.Input.ComboBoxSelectionChangedEventArgs e)
        {
            // implement your logic here
        }
    }
}