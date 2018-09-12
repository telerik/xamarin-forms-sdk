using Telerik.XamarinForms.DataGrid;
using Telerik.XamarinForms.DataGrid.Commands;

namespace SDKBrowser.Examples.DataGridControl.FilteringUICategory.CustomFilteringUIExample
{
    // >> datagrid-customfiltering-customcommand-cs
    public class CustomOptionsTapCommand : DataGridCommand
    {
        private TemplateColumnFilteringUI filterControl;

        public CustomOptionsTapCommand()
        {
            this.Id = DataGridCommandId.OptionsTap;
        }

        public override void Execute(object parameter)
        {
            var optionsTapContext = parameter as OptionsTapContext;
            if (optionsTapContext != null)
            {
                if (this.filterControl == null)
                {
                    this.filterControl = new TemplateColumnFilteringUI();
                }

                DataGridTypedColumn column = (DataGridTypedColumn)optionsTapContext.Column;
                this.filterControl.PropertyName = column.PropertyName;
                this.filterControl.FilterDescriptor = optionsTapContext.AssociatedDescriptor;
                optionsTapContext.FilterControl = filterControl;
            }

            this.Owner.CommandService.ExecuteDefaultCommand(DataGridCommandId.OptionsTap, optionsTapContext);
        }
    }
    // << datagrid-customfiltering-customcommand-cs
}
