using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ComboBoxControl.HowToCategory.SelectionWithCheckBoxExample
{
    // >> combobox-howto-selection-checkbox-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private ObservableCollection<object> selectedItems;
        private bool? selectAllChecked = false;
        private bool isInternalCheckChanged;

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

            this.SelectAllCommand = new Command(this.OnSelectAllCommandExecute);
        }

        public ObservableCollection<City> Items { get; set; }
        public ICommand SelectAllCommand { get; set; }

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
                    if (this.selectedItems != null)
                    {
                        this.selectedItems.CollectionChanged -= this.OnSelectedItemsCollectionChanged;
                    }

                    this.selectedItems = value;

                    if (this.selectedItems != null)
                    {
                        this.selectedItems.CollectionChanged += this.OnSelectedItemsCollectionChanged;
                    }

                    this.OnPropertyChanged();
                }
            }
        }

        public bool? SelectAllChecked
        {
            get
            {
                return this.selectAllChecked;
            }
            set
            {
                if (this.selectAllChecked != value)
                {
                    this.selectAllChecked = value;

                    if (!this.isInternalCheckChanged && this.selectAllChecked.HasValue)
                    {
                        if (this.selectAllChecked.Value)
                        {
                            foreach (var store in this.Items)
                            {
                                if (!this.SelectedItems.Contains(store))
                                {
                                    this.SelectedItems.Add(store);
                                }
                            }
                        }
                        else
                        {
                            this.SelectedItems.Clear();
                        }
                    }

                    this.OnPropertyChanged();
                }
            }
        }

        private void OnSelectAllCommandExecute(object obj)
        {
            if (this.selectAllChecked == null)
            {
                this.SelectAllChecked = false;
            }
            else
            {
                this.SelectAllChecked = !this.selectAllChecked;
            }
        }

        private void OnSelectedItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var action = e.Action;
            if (action == NotifyCollectionChangedAction.Add)
            {
                this.isInternalCheckChanged = true;
                if (this.SelectedItems.Count == this.Items.Count)
                {
                    this.SelectAllChecked = true;
                }
                else
                {
                    this.SelectAllChecked = null;
                }
                this.isInternalCheckChanged = false;

                return;
            }

            if (action == NotifyCollectionChangedAction.Remove)
            {
                this.isInternalCheckChanged = true;
                if (this.SelectedItems.Count == 0)
                {
                    this.SelectAllChecked = false;
                }
                else
                {
                    this.SelectAllChecked = null;
                }
                this.isInternalCheckChanged = false;
            }
        }
    }
    // << combobox-howto-selection-checkbox-viewmodel
}
