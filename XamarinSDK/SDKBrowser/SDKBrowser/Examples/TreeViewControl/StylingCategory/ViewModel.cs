using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory
{
    public class ViewModel
    {
        public ObservableCollection<Item> Source { get; set; }
        public ViewModel()
        {
            this.Source = new ObservableCollection<Item>();
            this.Source.Add(new Item("Item 1")
            {
                Children = new List<Item>()
                {
                    new Item("Item 11")
                    {
                        Children = new List<Item>()
                        {
                            new Item("Item 111"),
                            new Item("Item 112"),
                            new Item("Item 113")
                        }
                    },
                    new Item("Item 12")
                }
            });
            this.Source.Add(new Item("Item 2")
            {
                Children = new List<Item>()
                {
                    new Item("Item 21")
                    {
                        Children = new List<Item>()
                        {
                            new Item("Item 211"),
                            new Item("Item 212"),
                            new Item("Item 213")
                        }
                    },
                    new Item("Item 22")
                    {
                        Children = new List<Item>()
                        {
                            new Item("Item 221"),
                            new Item("Item 222"),
                            new Item("Item 223")
                        }
                    }
                }
            });
            this.Source.Add(new Item("Item 3")
            {
                Children = new List<Item>()
                {
                    new Item("Item 31")
                    {
                        Children = new List<Item>()
                        {
                            new Item( "Item 311"),
                            new Item("Item 312"),
                            new Item("Item 313")
                        }
                    },
                    new Item("Item 32")
                    {
                        Children = new List<Item>()
                        {
                            new Item("Item 321"),
                            new Item("Item 322"),
                            new Item("Item 323")
                        }
                    }
                }
            });
        }
    }
}
