using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.DataControls.TreeView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.CommandsExample
{
    // >> treeview-commands-viewmodel
    public class ViewModel
    {
        public ObservableCollection<Item> Source { get; set; }
        public ICommand MyTapCommand { get; set; }

        public ViewModel()
        {
            this.MyTapCommand = new Command((p) => OnItemTap(p));

            this.Source = new ObservableCollection<Item>();
            this.Source.Add(new Item("Contacts")
            {
                Children = new List<Item>()
                {
                    new Item("Bob Tony"),
                    new Item("Sue Winchell"),
                    new Item("Lui Sang")
                }
            });
            this.Source.Add(new Item("Lists")
            {
                Children = new List<Item>()
                {
                    new Item("Priorities"),
                    new Item("Opportunities"),
                    new Item("Issues")
                }
            });
            this.Source.Add(new Item("Reports")
            {
                Children = new List<Item>()
                {
                    new Item("December Sales"),
                    new Item("First Quarter Summary"),
                    new Item("Second Quarter Summary")
                }
            });
        }
        private void OnItemTap(object p)
        {
            var context = (TreeViewItemCommandContext)p;
            //add your logic here
            Application.Current.MainPage.DisplayAlert("", "You clicked on: " + (context.Item as Item).Name, "OK");
        }
    }
    // << treeview-commands-viewmodel
}
