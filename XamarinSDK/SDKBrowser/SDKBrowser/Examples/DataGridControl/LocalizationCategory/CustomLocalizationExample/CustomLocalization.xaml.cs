using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.LocalizationCategory.CustomLocalizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLocalization : ContentView
    {
        public CustomLocalization()
        {
            // >> datagrid-setting-the-custom-manager-csharp
            TelerikLocalizationManager.Manager = new CustomTelerikLocalizationManager();
            
            this.InitializeComponent();
            // << datagrid-setting-the-custom-manager-csharp
            this.BindingContext = new LocalizationViewModel();
        }
    }
 
    // >> datagrid-custom-localizationmanager-csharp
    public class CustomTelerikLocalizationManager : TelerikLocalizationManager
    {
        public override string GetString(string key)
        {
            if (key == "FilterText")
            {
                return "filtre";
            }

            if (key == "FilterUISectionText")
            {
                return "filtre par";
            }

            if (key == "Contains")
            {
                return "contient";
            }

            return base.GetString(key);
        }
    }
    // << datagrid-custom-localizationmanager-csharp
}