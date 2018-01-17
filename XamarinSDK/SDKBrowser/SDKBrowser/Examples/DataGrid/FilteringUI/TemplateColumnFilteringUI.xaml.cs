using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.XamarinForms.Common.Data;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplateColumnFilteringUI : DataGridFilterControlBase
    {
        public TemplateColumnFilteringUI()
        {
            InitializeComponent();
        }

        public FilterDescriptorBase FilterDescriptor { get; set; }

        public override FilterDescriptorBase BuildDescriptor()
        {
            TextFilterDescriptor textDescriptor = new TextFilterDescriptor();
            textDescriptor.PropertyName = this.PropertyName;
            textDescriptor.Value = this.textEntry.Text;
            textDescriptor.Operator = (TextOperator)this.descriptorOperatorPicker.SelectedIndex;

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

        private List<string> GetOperators()
        {
            var operators = Enum.GetNames(typeof(TextOperator)).ToList();
            return operators;
        }
    }
}