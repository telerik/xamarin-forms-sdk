using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Telerik.XamarinForms.Primitives.CheckBox.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CheckBoxControl.CommandsCategory.CheckBoxCommandsExample
{
     // >> checkbox-commands-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.IsCheckedChangedCommand = new Command((p) => IsCheckedChangedCommandExecute(p), (p) => IsCheckedChangedCommandCanExecute(p));
        }

        public ICommand IsCheckedChangedCommand { get; set; }

        private bool IsCheckedChangedCommandCanExecute(object p)
        {
            return true;
        }

        private void IsCheckedChangedCommandExecute(object p)
        {
            var context = p as CheckBoxIsCheckChangedCommandContext;
            if (context.NewState == true)
            {
                Application.Current.MainPage.DisplayAlert("Message", "Option selected", "OK");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Message", "You've unselected that option", "OK");
            }
        }
    }
    // << checkbox-commands-viewmodel
}
