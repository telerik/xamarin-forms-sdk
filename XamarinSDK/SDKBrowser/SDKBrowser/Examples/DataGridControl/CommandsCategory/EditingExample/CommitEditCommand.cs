using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataGrid.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.EditingExample
{
    // >> datagrid-commands-editing-commitedit
    public class CommitEditCommand : DataGridCommand
    {
        public CommitEditCommand()
        {
            this.Id = DataGridCommandId.CommitEdit;
        }

        public override void Execute(object parameter)
        {
            var context = (EditContext)parameter;
           
            Application.Current.MainPage.DisplayAlert("", "Edit Committed", "OK");
            this.Owner.CommandService.ExecuteDefaultCommand(DataGridCommandId.CommitEdit, parameter);
        }
    }
    // << datagrid-commands-editing-commitedit
}
