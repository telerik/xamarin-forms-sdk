using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ExpandCollapseExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TreeViewExpandCollapse : ContentView
	{
        public ObservableCollection<Item> Source { get; set; }
        public TreeViewExpandCollapse ()
		{
			InitializeComponent ();
            this.InitSources();
            this.tv.ItemsSource = this.Source;
        }
        private void InitSources()
        {
            this.Source = new ObservableCollection<Item>();
            this.Source.Add(new Item()
            {
                Name = "Item 1",
                Children = new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 11",
                            Children = new List<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 111",
                                },
                                new Item()
                                {
                                    Name = "Item 112"
                                },
                                new Item()
                                {
                                    Name = "Item 113"
                                }
                            }
                        },
                        new Item()
                        {
                            Name = "Item 12"
                        }
                    }
            });
            this.Source.Add(new Item()
            {
                Name = "Item 2",
                Children = new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 21",
                            Children = new List<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 211",
                                },
                                new Item()
                                {
                                    Name = "Item 212"
                                },
                                new Item()
                                {
                                    Name = "Item 213"
                                }
                            }
                        },
                        new Item()
                        {
                            Name = "Item 22",
                            Children = new List<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 221",
                                },
                                new Item()
                                {
                                    Name = "Item 222"
                                },
                                new Item()
                                {
                                    Name = "Item 223"
                                }
                            }
                        }
                    }
            });
        }

        private void ExpandItem2(object sender, EventArgs e)
        {
            this.tv.Expand(Source[1]);
        }

        private void ExpandItem211(object sender, EventArgs e)
        {
            this.tv.Expand(Source[1].Children[1]);
        }

        private void CollapseItem2(object sender, EventArgs e)
        {
            this.tv.Collapse(Source[1]);
        }

        private void CollapseItem211(object sender, EventArgs e)
        {
            this.tv.Collapse(Source[1].Children[1]);
        }

        private void ExpandAll(object sender, EventArgs e)
        {
            this.tv.ExpandAll();
        }

        private void CollapseAll(object sender, EventArgs e)
        {
            this.tv.CollapseAll();
        }
    }
}