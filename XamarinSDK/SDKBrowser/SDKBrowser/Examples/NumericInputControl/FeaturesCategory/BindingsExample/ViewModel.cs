using System.ComponentModel;

namespace SDKBrowser.Examples.NumericInputControl.FeaturesCategory.BindingsExample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double step;
        private double value;
        private double minimum;
        private double maximum;
        public ViewModel()
        {
            this.Step = 1;
            this.Value = 0;
            this.Minimum = 0;
            this.Maximum = 5;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public double Maximum
        {
            get
            {
                return this.maximum;
            }

            set
            {
                if (this.maximum != value)
                {
                    this.maximum = value;
                    OnPropertyChanged("Maximum");
                }
            }
        }
        public double Minimum
        {
            get
            {
                return this.minimum;
            }

            set
            {
                if (this.minimum != value)
                {
                    this.minimum = value;
                    OnPropertyChanged("Minimum");
                }
            }
        }
        public double Step
        {
            get
            {
                return this.step;
            }

            set
            {
                if (this.step != value)
                {
                    this.step = value;
                    OnPropertyChanged("Step");
                }
            }
        }
        public double Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    OnPropertyChanged("Value");
                }
            }
        }       
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}