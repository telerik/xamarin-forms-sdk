using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SelectionExample
{
    // >> comobobox-selection-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private int selectedIndex;
        private City selectedItem;
        private ObservableCollection<object> selectedItems;
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

            this.SelectedIndex = 1;
            this.SelectedItem = this.Items[2];
        }

        public ObservableCollection<City> Items { get; set; }

        public ObservableCollection<object> SelectedItems
        {
            get
            {
                return this.selectedItems;
            }
            set
            {
                if (this.selectedItems != value)
                {
                    this.selectedItems = value;

                    this.selectedItems.Add(this.Items[0]);
                    this.selectedItems.Add(this.Items[1]);

                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedIndex
        {
            get
            {
                return this.selectedIndex;
            }
            set
            {
                if (this.selectedIndex != value)
                {
                    this.selectedIndex = value;
                    OnPropertyChanged();
                }
            }
        }

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
                    OnPropertyChanged();
                }
            }
        }
    }
    // << comobobox-selection-viewmodel
}
