using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.BindableSelectedItemStyleExample
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            this.Source = new List<SourceItem> { new SourceItem("Tom"), new SourceItem("Anna"), new SourceItem("Peter"), new SourceItem("Teodor"), new SourceItem("Lorenzo"), new SourceItem("Andrea"), new SourceItem("Martin") };
        }

        public List<SourceItem> Source { get; set; }

        private Color backgroundColor = Color.Gray;
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

        private Color borderColor = Color.Gray;
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

        private Location borderLocation = Location.Bottom;
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

        private double borderWidth = 5;
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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}