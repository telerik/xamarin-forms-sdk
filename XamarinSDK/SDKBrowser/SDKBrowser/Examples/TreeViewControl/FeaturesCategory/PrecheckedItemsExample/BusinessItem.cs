using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.PrecheckedItemsExample
{
    public class BusinessItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string text;
        private ObservableCollection<BusinessItem> children;

        public string Text
        {
            get => this.text;
            set
            {
                if (this.text != value)
                {
                    this.text = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<BusinessItem> Children
        {
            get => children;
            set
            {
                if (this.children != value)
                {
                    this.children = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public BusinessItem()
        {
            this.children = new ObservableCollection<BusinessItem>();
        }

        public BusinessItem(string text) :
            this()
        {
            this.text = text;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}