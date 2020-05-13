using System.Collections.Generic;
using Telerik.XamarinForms.Common.Data;
using Telerik.XamarinForms.DataGrid;

namespace SDKBrowser.Examples.DataGridControl.FilteringCategory.FilterTemplateExample
{
    // >> datagrid-filtering-templatecolumn-filteringcontrol-cs
    public partial class PopulationFilter : DataGridFilterControlBase
    {
        public PopulationFilter()
        {
            InitializeComponent();
        }
        public FilterDescriptorBase FilterDescriptor { get; set; }

        public override FilterDescriptorBase BuildDescriptor()
        {
            TextFilterDescriptor textDescriptor = new TextFilterDescriptor();
            textDescriptor.PropertyName = this.PropertyName;
            textDescriptor.Value = this.textEntry.Text;
            textDescriptor.Operator = (TextOperator)this.descriptorOperatorPicker.SelectedItem;

            return textDescriptor;
        }

        protected override void Initialize()
        {
            this.descriptorOperatorPicker.ItemsSource = this.GetOperators();
            var textFilterDescriptor = this.FilterDescriptor as TextFilterDescriptor;
            if (textFilterDescriptor != null)
            {
                this.descriptorOperatorPicker.SelectedIndex = (int)textFilterDescriptor.Operator;
                this.textEntry.Text = textFilterDescriptor.Value.ToString();
            }
            else
            {
                this.descriptorOperatorPicker.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(this.textEntry.Text))
                {
                    this.textEntry.Text = null;
                }
            }
        }
        private List<TextOperator> GetOperators()
        {
            var operators = new List<TextOperator>
            {
                TextOperator.Contains,
                TextOperator.DoesNotContain,
                TextOperator.StartsWith,
                TextOperator.EndsWith,
            };
            return operators;
        }
    }
    // << datagrid-filtering-templatecolumn-filteringcontrol-cs
}