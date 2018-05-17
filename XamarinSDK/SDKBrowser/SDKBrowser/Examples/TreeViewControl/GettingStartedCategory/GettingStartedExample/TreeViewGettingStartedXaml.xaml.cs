using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls.TreeView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewGettingStartedXaml : ContentView
    {
        public ObservableCollection<Item> SourceCollection { get; set; } = new ObservableCollection<Item>();
        public TreeViewGettingStartedXaml()
        {
            InitializeComponent();
            InitSources();
            this.tv.BindingContext = this;
            this.tv.HierarchyAdapter = new TreeViewDemoAdapter();
        }

        private void InitSources()
        {
            this.SourceCollection.Add(new Item()
            {
                Name = "Item 1",
                Children = new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 11",
                            Children = new ObservableCollection<Item>()
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
            this.SourceCollection.Add(new Item()
            {
                Name = "Item 2",
                Children = new ObservableCollection<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 21",
                            Children = new ObservableCollection<Item>()
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
                            Children = new ObservableCollection<Item>()
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

            this.SourceCollection.Add(new Item()
            {
                Name = "Item 1",
                Children = new ObservableCollection<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 11",
                            Children = new ObservableCollection<Item>()
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
            this.SourceCollection.Add(new Item()
            {
                Name = "Item 2",
                Children = new ObservableCollection<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 21",
                            Children = new ObservableCollection<Item>()
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
                            Children = new ObservableCollection<Item>()
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
            this.SourceCollection.Add(new Item()
            {
                Name = "Item 3",
                Children = new ObservableCollection<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 31",
                            Children = new ObservableCollection<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 311",
                                },
                                new Item()
                                {
                                    Name = "Item 312"
                                },
                                new Item()
                                {
                                    Name = "Item 313"
                                }
                            }
                        },
                        new Item()
                        {
                            Name = "Item 32",
                            Children = new ObservableCollection<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 321",
                                },
                                new Item()
                                {
                                    Name = "Item 322"
                                },
                                new Item()
                                {
                                    Name = "Item 323"
                                }
                            }
                        }
                    }
            });
            this.SourceCollection.Add(new Item()
            {
                Name = "Item 4",
                Children = new ObservableCollection<Item>()
                    {
                        new Item()
                        {
                            Name = "Item 41",
                            Children = new ObservableCollection<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 411",
                                },
                                new Item()
                                {
                                    Name = "Item 412"
                                },
                                new Item()
                                {
                                    Name = "Item 413"
                                }
                            }
                        },
                        new Item()
                        {
                            Name = "Item 42",
                            Children = new ObservableCollection<Item>()
                            {
                                new Item()
                                {
                                    Name = "Item 421",
                                },
                                new Item()
                                {
                                    Name = "Item 422"
                                },
                                new Item()
                                {
                                    Name = "Item 423"
                                }
                            }
                        }
                    }
            });
        }
    }
}