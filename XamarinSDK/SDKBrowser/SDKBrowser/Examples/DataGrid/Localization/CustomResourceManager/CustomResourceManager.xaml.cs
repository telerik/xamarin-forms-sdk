using SDKBrowser.Examples.DataGrid.Filtering;
using SDKBrowser.Examples.DataGrid.Localization.Resources;
using System;
using Telerik.XamarinForms.Common.Data;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomResourceManager : ContentPage
    {
        public CustomResourceManager()
        { 
            // >> datagrid-setting-the-custom-resource-manager-csharp
            DataGridLocalizationManager.Manager.ResourceManager = DataGridResource.ResourceManager;
            InitializeComponent();
            // << datagrid-setting-the-custom-resource-manager-csharp
            this.BindingContext = new ViewModel();
        }
    }
}