using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataControls.ListView;

namespace SDKBrowser.Examples.ListViewControl.BindableCollectionsCategory.SortDescriptorsExample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool isPropertyNameSortSwitchToggled;
        private bool isSortOrderSortSwitchToggled;
        private List<Event> items;
        private ObservableCollection<SortDescriptorBase> sortDescriptors;

        public ViewModel()
        {
            this.Items = this.GetItems();
            this.sortDescriptors = new ObservableCollection<SortDescriptorBase>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsPropertyNameSortSwitchToggled
        {
            get
            {
                return this.isPropertyNameSortSwitchToggled;
            }
            set
            {
                if (this.isPropertyNameSortSwitchToggled != value)
                {
                    this.isPropertyNameSortSwitchToggled = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsSortOrderSortSwitchToggled
        {
            get
            {
                return this.isSortOrderSortSwitchToggled;
            }
            set
            {
                if (this.isSortOrderSortSwitchToggled != value)
                {
                    this.isSortOrderSortSwitchToggled = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<Event> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                if (this.items != value)
                {
                    this.items = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<SortDescriptorBase> SortDescriptors
        {
            get
            {
                return this.sortDescriptors;
            }
            set
            {
                if (this.sortDescriptors != value)
                {
                    this.sortDescriptors = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<Event> GetItems()
        {
            var results = new List<Event>();

            results.Add(new Event() { Content = "Content of the item", Day = "Tommorow", Category = "A" });
            results.Add(new Event() { Content = "This also happens today", Day = "Yesterday", Category = "A" });
            results.Add(new Event() { Content = "More events today", Day = "Today", Category = "A" });
            results.Add(new Event() { Content = "Go shopping after 19:00", Day = "Yesterday", Category = "B" });
            results.Add(new Event() { Content = "You are now free to do whathever", Day = "Today", Category = "B" });

            results.Add(new Event() { Content = "For tommorow", Day = "Today", Category = "B" });
            results.Add(new Event() { Content = "It is a free day", Day = "Yesterday", Category = "C" });
            results.Add(new Event() { Content = "Go have some fun", Day = "Tommorow", Category = "C" });
            results.Add(new Event() { Content = "Party", Day = "Tommorow", Category = "C" });

            return results;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.UpdateExistingSortDescriptor(propertyName);
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateExistingSortDescriptor(string propertyToUpdate)
        {
            if (this.SortDescriptors == null)
                return;

            if (this.SortDescriptors.Count == 0)
            {
                this.SortDescriptors.Add(new PropertySortDescriptor()
                {
                    PropertyName = "Day",
                    SortOrder = SortOrder.Ascending
                });
            }

            if (propertyToUpdate.Equals(nameof(IsSortOrderSortSwitchToggled)))
            {
                var descriptor = (PropertySortDescriptor)this.SortDescriptors.FirstOrDefault();
                descriptor.SortOrder = isSortOrderSortSwitchToggled ? SortOrder.Descending : SortOrder.Ascending;
            }
            else if (propertyToUpdate.Equals(nameof(IsPropertyNameSortSwitchToggled)))
            {
                var descriptor = (PropertySortDescriptor)this.SortDescriptors.FirstOrDefault();
                descriptor.PropertyName = isPropertyNameSortSwitchToggled ? "Category" : "Day";
            }
        }
    }
}