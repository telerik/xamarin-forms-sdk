using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.GettingStartedCategory.GettingStartedExample
{
    // >> treeview-getting-started-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            Source = new ObservableCollection<Item>();
            Source.Add(new Item("My Documents")
            {              
                Children = new List<Item>()
                {
                    new Item("Xamarin Projects")
                    {
                        Children = new ObservableCollection<Item>()
                        {
                            new Item("TreeView Examples"),
                            new Item("Calendar & Scheduling QSF")
                        }
                    },
                    new Item("Documentation Drafts")
                }
            });
            Source.Add(new Item("Shared Documents")
            {
                Children = new List<Item>()
                {
                    new Item("Reports")
                    {
                        Children = new List<Item>()
                        {
                            new Item("October"),
                            new Item("November"),
                            new Item("December")
                        }
                    }
                }
            });
        }
        public ObservableCollection<Item> Source { get; set; }
    }
    // << treeview-getting-started-viewmodel
}
