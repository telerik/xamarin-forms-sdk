using Telerik.XamarinForms.DataGrid;
using Telerik.XamarinForms.DataGrid.Commands;

namespace SDKBrowser.Examples.DataGrid.FilteringUI
{
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
                var column = optionsTapContext.Column as DataGridTemplateColumn;
                if (column != null)
                {
                    if (this.filterControl == null)
                    {
                        this.filterControl = new TemplateColumnFilteringUI();
                    }

                    this.filterControl.PropertyName = nameof(Player.Country);
                    this.filterControl.FilterDescriptor = optionsTapContext.AssociatedDescriptor;
                    optionsTapContext.FilterControl = filterControl;
                }
            }

            this.Owner.CommandService.ExecuteDefaultCommand(DataGridCommandId.OptionsTap, optionsTapContext);
        }
    }
}
