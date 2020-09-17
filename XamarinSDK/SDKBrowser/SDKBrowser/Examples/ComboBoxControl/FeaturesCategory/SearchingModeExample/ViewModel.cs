using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SearchingModeExample
{
    // >> combobox-searching-mode-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private SearchMode searchMode;

        public ViewModel()
        {
            this.Stores = new ObservableCollection<StoreAddress>();
            this.Stores.Add(new StoreAddress() { City = "New York", Street = "536 Halifax Road", Code = "Woodside, NY 11377", WorkHours = "Open 11am to 6pm" });
            this.Stores.Add(new StoreAddress() { City = "New Jersey", Street = "4759 Cherry Camp Road", Code = "NJ 07097", WorkHours = "Open 10am to 7pm" });
            this.Stores.Add(new StoreAddress() { City = "San Francisco", Street = "3082 Rardin Drive", Code = "CA 94107", WorkHours = "Open 10am to 7pm" });
            this.Stores.Add(new StoreAddress() { City = "San Diego", Street = "1593 Hood Avenue", Code = "CA 92123", WorkHours = "Open 11am to 6pm" });
            this.Stores.Add(new StoreAddress() { City = "Los Angeles", Street = "28 Woodstock Drive", Code = "CA 90017", WorkHours = "Open 6am to 9pm" });
            this.Stores.Add(new StoreAddress() { City = "Dallas", Street = "2586 Sardis Sta", Code = "X 75201", WorkHours = "Open 10am to 9pm" });
            this.Stores.Add(new StoreAddress() { City = "Austin", Street = "3684 Sundown Lane", Code = "TX 78741", WorkHours = "Open 10am to 67pm" });
        }

        public ObservableCollection<StoreAddress> Stores { get; set; }

        public SearchMode SearchMode
        {
            get
            {
                return this.searchMode;
            }
            set
            {
                if (this.searchMode != value)
                {
                    this.searchMode = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
    // << combobox-searching-mode-viewmodel
}
