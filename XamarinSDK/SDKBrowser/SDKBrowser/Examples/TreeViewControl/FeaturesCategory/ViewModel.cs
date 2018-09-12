using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory
{
    public class ViewModel
    {
        public ObservableCollection<Item> Source
        {
            get; set;
        }

        public ViewModel()
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
            this.Source.Add(new Item()
            {
                Name = "Item 3",
                Children = new List<Item>()
                {
                    new Item()
                    {
                        Name = "Item 31",
                        Children = new List<Item>()
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
                        Children = new List<Item>()
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
        }
    }
}
