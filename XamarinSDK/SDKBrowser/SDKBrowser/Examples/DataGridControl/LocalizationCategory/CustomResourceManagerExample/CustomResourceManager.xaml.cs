using SDKBrowser.Examples.DataGridControl.LocalizationCategory.Resources;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.LocalizationCategory.CustomResourceManagerExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomResourceManager : ContentView
    {
        public CustomResourceManager()
        { 
            // >> datagrid-setting-the-custom-resource-manager-csharp
            DataGridLocalizationManager.Manager.ResourceManager = DataGridResource.ResourceManager;
            this.InitializeComponent();
            // << datagrid-setting-the-custom-resource-manager-csharp
            this.BindingContext = new LocalizationViewModel();
        }
    }
}