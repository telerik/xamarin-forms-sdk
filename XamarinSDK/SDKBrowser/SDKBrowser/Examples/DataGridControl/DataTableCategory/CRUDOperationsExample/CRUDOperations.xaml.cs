using System;
using System.Linq;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.DataTableCategory.CrudOperationsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrudOperations : ContentView
    {
        DataTableViewModel viewModel;
        public CrudOperations() 
        {
            InitializeComponent();
            this.viewModel = new DataTableViewModel();
            this.BindingContext = viewModel;
        }

        // >> datagrid-datatable-add-row
        private void AddDataClicked(object sender, EventArgs e)
        {
            this.viewModel.Data.Rows.Add(12, "Madrid", 3223000, null, false);
        }
        // << datagrid-datatable-add-row

        // >> datagrid-datatable-update-data
        private void UpdateDataClicked(object sender, EventArgs e)
        {
            if (this.viewModel.Data.Rows.Count > 0)
            {
                this.viewModel.Data.Rows[0]["City"] = "Seoul";
                this.viewModel.Data.Rows[0]["Population"] = 9776000;
            }
        }
        // << datagrid-datatable-update-data

        // >> datagrid-datatable-delete-data
        private void DeleteDataClicked(object sender, EventArgs e)
        {
            int rowCount = this.viewModel.Data.Rows.Count;
            if (rowCount > 0)
            {
                this.viewModel.Data.Rows.RemoveAt(rowCount - 1);
            }
        }
        // << datagrid-datatable-delete-data

        // >> datagrid-datatable-selection
        private void RadDataGrid_SelectionChanged(object sender, Telerik.XamarinForms.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count() > 0)
            {
                var selectedItem = e.AddedItems.First() as DataGridCellInfo;
                Application.Current.MainPage.DisplayAlert("You have selected", $"{selectedItem.Value}", "OK");
            }
        }
        // << datagrid-datatable-selection
    }
}