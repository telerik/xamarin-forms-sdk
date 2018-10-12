using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.ValidationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Validation : ContentView
    {
        public Validation()
        {
            InitializeComponent();
            // >> datagrid-commands-validation-binding
            this.BindingContext = new ViewModel();
            this.dataGrid.Commands.Add(new ValidateCellCommand(errorContainer));
            // << datagrid-commands-validation-binding
        }
    }
}