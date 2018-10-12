using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataGrid.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.EditingExample
{
    // >> datagrid-commands-editing-beginedit
    public class BeginEditCommand : DataGridCommand
    {
        public BeginEditCommand()
        {
            this.Id = DataGridCommandId.BeginEdit;
        }

        public override void Execute(object parameter)
        {
            var context = (EditContext)parameter;
            var cellEdit = $"BeginEdit on: {context.CellInfo.Value} via {context.TriggerAction} \n";
            Application.Current.MainPage.DisplayAlert("", "" + cellEdit, "OK");
            this.Owner.CommandService.ExecuteDefaultCommand(DataGridCommandId.BeginEdit, parameter);
        }
    }
    // << datagrid-commands-editing-beginedit
}
