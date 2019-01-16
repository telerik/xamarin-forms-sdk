using SDKBrowser.Examples.DataFormControl.GlobalizationCategory.GlobalizationExample.Resources;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.GlobalizationCategory.GlobalizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormGlobalization : ContentView
    {
        // >> dataform-globalization-setting-resourcemanager
        public DataFormGlobalization()
        {
            DataFormLocalizationManager.Manager = DataFormResources.ResourceManager;
            InitializeComponent();
        }
        // << dataform-globalization-setting-resourcemanager
    }
}