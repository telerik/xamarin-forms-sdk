using System.ComponentModel;

namespace SDKBrowser.Examples.DataGrid.FilteringUI
{
    /// <summary>
    /// A football player.
    /// </summary>
    public class Player : INotifyPropertyChanged
    {
        private string name;
        private int? number;
        private string country;

        public Player(string name, int number, string country)
        {
            this.name = name;
            this.number = number;
            this.country = country;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        public int? Number
        {
            get { return this.number; }
            set
            {
                if (value != this.number)
                {
                    this.number = value;
                    this.OnPropertyChanged(nameof(this.Number));
                }
            }
        }

        public string Country
        {
            get { return this.country; }
            set
            {
                if (value != this.country)
                {
                    this.country = value;
                    this.OnPropertyChanged(nameof(this.Country));
                }
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            this.PropertyChanged?.Invoke(this, args);
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
