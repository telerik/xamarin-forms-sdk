using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadMoreDataCommand : ContentPage
    {
        public LoadMoreDataCommand()
        {
            InitializeComponent();
            
            this.BindingContext = new LoadMoreDataCommandViewModel();
            // >> datagrid-customloadmoredatacommand-addtocollection-csharp
            this.dataGrid.Commands.Add(new DataGrid.CustomLoadMoreDataCommand());
            // << datagrid-customloadmoredatacommand-addtocollection-csharp
        }

    }
}