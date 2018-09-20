using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataControls.TreeView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.CheckBoxesExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TreeViewCheckboxes : ContentView
	{
        public ObservableCollection<Item> SmallSource { get; set; }
        public TreeViewCheckboxes ()
		{
            this.SmallSource = new ObservableCollection<Item>();
            this.InitSources();
            this.BindingContext = this;
            InitializeComponent ();
            tv.CheckedItems.CollectionChanged += CheckedItems_CollectionChanged;
        }
        private void CheckedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var ci = this.tv.CheckedItems as TreeViewItemsCollection;
            this.CheckedItemsCount.Text = ci.Count.ToString();
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
        public void Clicked(object sender, EventArgs e)
        {
            if (this.tv.CheckBoxMode == Telerik.XamarinForms.DataControls.TreeView.CheckBoxModes.None)
            {
                this.tv.CheckBoxMode = Telerik.XamarinForms.DataControls.TreeView.CheckBoxModes.Individual;
            }
            else if (this.tv.CheckBoxMode == Telerik.XamarinForms.DataControls.TreeView.CheckBoxModes.Individual)
            {
                this.tv.CheckBoxMode = Telerik.XamarinForms.DataControls.TreeView.CheckBoxModes.Propagate;
            }
            else
            {
                this.tv.CheckBoxMode = Telerik.XamarinForms.DataControls.TreeView.CheckBoxModes.None;
            }
        }
    }
}