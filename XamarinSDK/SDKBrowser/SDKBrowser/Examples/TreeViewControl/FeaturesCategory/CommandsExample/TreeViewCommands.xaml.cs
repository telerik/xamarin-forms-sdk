using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SDKBrowser.Examples.TreeViewControl.GettingStartedCategory.GettingStartedExample;
using Telerik.XamarinForms.DataControls.TreeView.Commands;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.CommandsExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TreeViewCommands : ContentView
	{
        public ObservableCollection<Item> SmallSource { get; set; }
        public ICommand MyTapCommand { get; set; }
        public ICommand MyHoldCommand { get; set; }
        public TreeViewCommands ()
		{
            this.SmallSource = new ObservableCollection<Item>();
            this.InitSources();
            this.BindingContext = this;

            this.MyTapCommand = new Command((p) => OnItemTap(p));
            this.MyHoldCommand = new Command((p) => OnItemHold(p));

            InitializeComponent ();

            this.tv.HierarchyAdapter = new TreeViewDemoAdapter();
        }

        private void OnItemHold(object p)
        {
            var context = (TreeViewItemCommandContext)p;
            this.tv.Expand(context.Item);
        }

        private void OnItemTap(object p)
        {
            var context = (TreeViewItemCommandContext)p;
            this.tv.Collapse(context.Item);
        }

        private void InitSources()
        {
            this.SmallSource.Add(new Item()
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
            this.SmallSource.Add(new Item()
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
    }
}