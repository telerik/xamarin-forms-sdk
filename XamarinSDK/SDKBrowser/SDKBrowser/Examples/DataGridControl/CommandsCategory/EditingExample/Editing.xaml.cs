using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.EditingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editing : ContentView
    {
        public Editing()
        {
            InitializeComponent();
            // >> datagrid-commands-editing-binding
            this.BindingContext = new ViewModel();
            dataGrid.Commands.Add(new BeginEditCommand());
            dataGrid.Commands.Add(new CommitEditCommand());
            // << datagrid-commands-editing-binding
        }
    }
}