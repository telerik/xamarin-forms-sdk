using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ComboBoxControl.HowToCategory.DropDownClearButtonExample
{
    // >> combobox-howto-dropdown-clearbutton-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private City selectedItem;
        private bool isDropDownOpen;

        public ViewModel()
        {
            this.Items = new ObservableCollection<City>
            {
                new City { Name = "Tokyo", Population = 13929286 },
                new City { Name = "New York", Population = 8623000 },
                new City { Name = "London", Population = 8908081 },
                new City { Name = "Madrid", Population = 3223334 },
                new City { Name = "Los Angeles", Population = 4000000},
                new City { Name = "Paris", Population = 2141000 },
                new City { Name = "Beijing", Population = 21540000 },
                new City { Name = "Singapore", Population = 5612000 },
                new City { Name = "New Delhi", Population = 18980000 },
                new City { Name = "Bangkok", Population = 8305218 },
                new City { Name = "Berlin", Population = 3748000 },
            };

            this.ClearSelectionCommand = new Command(this.OnClearSelectionCommandExecuted);
        }

        public ObservableCollection<City> Items { get; set; }
        public ICommand ClearSelectionCommand { get; set; }

        public City SelectedItem
        {
            get
            {
                return this.selectedItem;
            }
            set
            {
                if (this.selectedItem != value)
                {
                    this.selectedItem = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public bool IsDropDownOpen
        {
            get
            {
                return this.isDropDownOpen;
            }
            set
            {
                if (this.isDropDownOpen != value)
                {
                    this.isDropDownOpen = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private void OnClearSelectionCommandExecuted(object obj)
        {
            this.SelectedItem = null;
            this.IsDropDownOpen = false;
        }
    }
    // << combobox-howto-dropdown-clearbutton-viewmodel
}
