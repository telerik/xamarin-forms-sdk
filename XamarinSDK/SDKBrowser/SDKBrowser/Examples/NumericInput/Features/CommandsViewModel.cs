using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.NumericInput
{
    // >> numericinput-features-commands-viewmodel
    public class CommandsViewModel : INotifyPropertyChanged
    {
        private double value;
        public event PropertyChangedEventHandler PropertyChanged;
        public CommandsViewModel()
        {
            this.CustomIncreaseCommand = new Command(this.IncreaseCommandExecute, this.IncreaseCommandCanExecute);
            this.CustomDecreaseCommand = new Command(this.DecreaseCommandExecute, this.DecreaseCommandCanExecute);
            this.Step = 1;
            this.Value = 0;
            this.Minimum = 0;
            this.Maximum = 5;
        }
        public double Maximum { get; set; }
        public double Minimum { get; set; }
        public double Step { get; set; }
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
        public ICommand CustomDecreaseCommand { get; set; }
        public ICommand CustomIncreaseCommand { get; set; }
        private bool DecreaseCommandCanExecute(object arg)
        {
            return true;
        }
        private void DecreaseCommandExecute(object obj)
        {
            double newValue = this.Value - this.Step;
            if (newValue >= this.Minimum)
                this.Value = newValue;
            else
                this.Value = this.Maximum;
        }
        private bool IncreaseCommandCanExecute(object arg)
        {
            return true;
        }
        private void IncreaseCommandExecute(object obj)
        {
            double nextValue = this.Value + this.Step;
            if (nextValue <= this.Maximum)
                this.Value = nextValue;
            else
                this.Value = this.Minimum;
        }
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    // << numericinput-features-commands-viewmodel
}
