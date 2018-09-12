using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleSelectorExample
{
    public class Item : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public IList<Item> Children { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Item()
        {
            this.Children = new ObservableCollection<Item>();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var eh = this.PropertyChanged;
            if (eh != null)
                eh.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}