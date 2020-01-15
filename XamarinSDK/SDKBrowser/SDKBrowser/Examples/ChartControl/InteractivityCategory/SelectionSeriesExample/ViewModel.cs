using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.SelectionSeriesExample
{
    // >> chart-selection-behavior-view-model
    public class ViewModel : NotifyPropertyChangedBase
    {
        private int counter = 0;
        private string displayCount;
        public ObservableCollection<CategoricalData> Data1 { get; set; }
        public ObservableCollection<CategoricalData> Data2 { get; set; }
        public ICommand IsSelectionChangedCommand { get; }

        public ViewModel()
        {
            this.Data1 = GetCategoricalData1();
            this.Data2 = GetCategoricalData2();
            this.IsSelectionChangedCommand = new Command(this.IncreaseCount);
        }
        public int Counter
        {
            get
            {
                return this.counter;
            }
            set
            {
                this.counter = value;
                this.DisplayCount = $"Command executed {counter} times.";
            }
        }
        public string DisplayCount
        {
            get
            {
                return this.displayCount;
            }
            set
            {
                if (this.displayCount != value)
                {
                    this.displayCount = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData1()
        {
            var data = new ObservableCollection<CategoricalData>
            {
                new CategoricalData { Category = "Greenings", Value = 52 },
                new CategoricalData { Category = "Perfecto", Value = 60 },
                new CategoricalData { Category = "NearBy", Value = 77 },
                new CategoricalData { Category = "Family", Value = 50 },
                new CategoricalData { Category = "Fresh", Value = 56 },
            };
            return data;
        }

        private static ObservableCollection<CategoricalData> GetCategoricalData2()
        {
            var data = new ObservableCollection<CategoricalData>  
            {
                new CategoricalData { Category = "Greenings", Value = 33 },
                new CategoricalData { Category = "Perfecto", Value = 88 },
                new CategoricalData { Category = "NearBy", Value = 61 },
                new CategoricalData { Category = "Family", Value = 94 },
                new CategoricalData { Category = "Fresh", Value = 72 },
            };
            return data;
        }
        private void IncreaseCount()
        {
            this.Counter++;
        }
    }
    // << chart-selection-behavior-view-model
}
