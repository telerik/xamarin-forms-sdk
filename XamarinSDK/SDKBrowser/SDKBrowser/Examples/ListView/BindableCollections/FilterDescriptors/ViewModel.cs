using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.DataControls.ListView;

namespace SDKBrowser.Examples.ListView.BindableCollections.FilterDescriptors
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<FilterDescriptorBase> filterDescriptors;
        private bool isFilterSwitchToggled;
        private List<Event> items;

        public ViewModel()
        {
            this.Items = this.GetItems();
            this.filterDescriptors = new ObservableCollection<FilterDescriptorBase>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<FilterDescriptorBase> FilterDescriptors
        {
            get
            {
                return this.filterDescriptors;
            }
            set
            {
                if (this.filterDescriptors != value)
                {
                    this.filterDescriptors = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsFilterSwitchToggled
        {
            get
            {
                return this.isFilterSwitchToggled;
            }
            set
            {
                if (this.isFilterSwitchToggled != value)
                {
                    this.isFilterSwitchToggled = value;
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
            this.UpdateExistingFilterDescriptor(propertyName);
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateExistingFilterDescriptor(string propertyName)
        {
            if (this.FilterDescriptors == null)
                return;

            if (this.FilterDescriptors.Count == 0)
            {
                this.FilterDescriptors.Add(new DelegateFilterDescriptor()
                {
                    Filter = new Func<object, bool>((item) => ((Event)item).Category.Equals("A"))
                });
            }

            if(propertyName.Equals(nameof(IsFilterSwitchToggled)))
            {
                ((DelegateFilterDescriptor)this.FilterDescriptors.FirstOrDefault()).Filter = 
                                this.isFilterSwitchToggled ?
                                new Func<object, bool>((item) => ((Event)item).Category.Equals("C")) :
                                new Func<object, bool>((item) => ((Event)item).Category.Equals("A"));
            }            
        }
    }
}