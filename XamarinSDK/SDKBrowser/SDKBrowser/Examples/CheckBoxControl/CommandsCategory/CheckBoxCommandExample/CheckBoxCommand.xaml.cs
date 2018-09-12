using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CheckBoxControl.CommandsCategory.CheckBoxCommandExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckBoxCommand : ContentView
	{
        // >> checkbox-commands-csharp
        public ICommand IsCheckedChangedCommand { get; set; }
        public CheckBoxCommand ()
        {
            this.IsCheckedChangedCommand = new Command((p) => IsCheckedChangedCommandExecute(p), (p) => IsCheckedChangedCommandCanExecute(p));
            this.BindingContext = this;
            InitializeComponent ();
        }
        private bool IsCheckedChangedCommandCanExecute(object p)
        {
            return true;
        }
        private void IsCheckedChangedCommandExecute(object p)
        {
            this.label.Text = "CheckBox User Command executed at " + DateTime.Now.ToLocalTime();
        }
        // << checkbox-commands-csharp
    }
}