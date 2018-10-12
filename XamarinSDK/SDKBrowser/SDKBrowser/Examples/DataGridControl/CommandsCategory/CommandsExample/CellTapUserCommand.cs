using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataGrid;
using Telerik.XamarinForms.DataGrid.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.CommandsExample
{
    public class CellTapUserCommand : DataGridCommand
    {
        // >> datagrid-commands-celltap
        public CellTapUserCommand()
        {
            Id = DataGridCommandId.CellTap;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            var context = parameter as DataGridCellInfo;
            var cellTap =  $"CellTap Command on cell {context.Value} inside {context.Column.HeaderText} \n";
            Application.Current.MainPage.DisplayAlert("", "You've selected " + cellTap, "OK");
            this.Owner.CommandService.ExecuteDefaultCommand(DataGridCommandId.CellTap, parameter);
        }
        // << datagrid-commands-celltap
    }
}
