using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleExample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Color backgroundColor = Color.Gray;
        private Color borderColor = Color.White;
        private Location borderLocation = Location.Bottom;
        private double borderWidth = 5;

        public ViewModel()
        {
            this.SmallSource = new ObservableCollection<Item>();
            this.InitSources();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Color Background
        {
            get
            {
                return this.backgroundColor;
            }
            set
            {
                if (this.backgroundColor != value)
                {
                    this.backgroundColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                if (this.borderColor != value)
                {
                    this.borderColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public Location BorderLocation
        {
            get
            {
                return this.borderLocation;
            }
            set
            {
                if (this.borderLocation != value)
                {
                    this.borderLocation = value;
                    OnPropertyChanged();
                }
            }
        }

        public double BorderWidth
        {
            get
            {
                return this.borderWidth;
            }
            set
            {
                if (this.borderWidth != value)
                {
                    this.borderWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Item> SmallSource { get; set; }

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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}