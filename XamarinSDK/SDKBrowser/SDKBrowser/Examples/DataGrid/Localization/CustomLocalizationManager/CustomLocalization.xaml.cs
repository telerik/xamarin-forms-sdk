using SDKBrowser.Examples.DataGrid.Filtering;
using System;
using Telerik.XamarinForms.Common.Data;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLocalization : ContentPage
    {
        public CustomLocalization()
        {
            // >> datagrid-setting-the-custom-manager-csharp
            DataGridLocalizationManager.Manager = new CustomDataGridLocalizationManager();
            InitializeComponent();
            // << datagrid-setting-the-custom-manager-csharp
            this.BindingContext = new ViewModel();
        }
    }
 
    // >> datagrid-custom-localizationmanager-csharp
    public class CustomDataGridLocalizationManager : DataGridLocalizationManager
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