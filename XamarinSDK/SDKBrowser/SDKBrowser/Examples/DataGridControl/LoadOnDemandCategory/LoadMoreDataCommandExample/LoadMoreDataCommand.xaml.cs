using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.LoadOnDemandCategory.LoadMoreDataCommandExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadMoreDataCommand : ContentView
    {
        public LoadMoreDataCommand()
        {
            this.InitializeComponent();
            
            this.BindingContext = new LoadMoreDataCommandViewModel();
            // >> datagrid-customloadmoredatacommand-addtocollection-csharp
            this.dataGrid.Commands.Add(new CustomLoadMoreDataCommand());
            // << datagrid-customloadmoredatacommand-addtocollection-csharp
        }

    }
}