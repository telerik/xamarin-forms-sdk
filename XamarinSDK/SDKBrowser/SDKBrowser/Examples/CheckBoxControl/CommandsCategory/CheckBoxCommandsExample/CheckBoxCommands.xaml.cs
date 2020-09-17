using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CheckBoxControl.CommandsCategory.CheckBoxCommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckBoxCommands : ContentView
	{     
        public CheckBoxCommands()
        {           
            InitializeComponent();

            // >> checkbox-commands-csharp
            this.BindingContext = new ViewModel();
            // << checkbox-commands-csharp
        }
    }
}