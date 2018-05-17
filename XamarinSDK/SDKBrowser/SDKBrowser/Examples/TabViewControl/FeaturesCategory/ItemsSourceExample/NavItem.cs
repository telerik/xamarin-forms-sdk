using System.ComponentModel;

namespace SDKBrowser.Examples.TabViewControl.FeaturesCategory.ItemsSourceExample
{
    public class NavItem : INotifyPropertyChanged
    {
        private string headerTitle;
        private int badgeCount;
        private string text;

        public string HeaderTitle
        {
            get
            {
                return this.headerTitle;
            }
            set
            {
                if (this.headerTitle != value)
                {
                    this.headerTitle = value;
                    this.RaisePropertyChanged(nameof(HeaderTitle));
                }
            }
        }

        public int BadgeCount
        {
            get
            {
                return this.badgeCount;
            }
            set
            {
                if (this.badgeCount != value)
                {
                    this.badgeCount = value;
                    this.RaisePropertyChanged(nameof(BadgeCount));
                }
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                if (this.text != value)
                {
                    this.text = value;
                    this.RaisePropertyChanged(nameof(Text));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

