using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using Telerik.XamarinForms.DataControls.ListView.Commands;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.CommandsExample
{ 
    // >> listview-features-commands-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<string> {"Tom", "Anna", "Peter", "Teodor", "Martin"};
            this.ItemTapCommand = new Command<ItemTapCommandContext>(this.ItemTapped);
        }
        private void ItemTapped(ItemTapCommandContext context)
        {
            var tappedItem = context.Item;
            //add your logic here
            Application.Current.MainPage.DisplayAlert("", "You've selected " + tappedItem, "OK");
        }
        public List<string> Source { get; set; }
        public ICommand ItemTapCommand { get; set; }
    }
    // << listview-features-commands-viewmodel
}
