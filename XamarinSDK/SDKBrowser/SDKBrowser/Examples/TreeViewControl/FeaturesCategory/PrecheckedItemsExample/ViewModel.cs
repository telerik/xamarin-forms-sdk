using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.PrecheckedItemsExample
{
    public class ViewModel
    {
        public static readonly string ItemCheckedMessageName = "Checked";
        public static readonly string ItemUncheckedMessageName = "Unchecked";
        public static readonly string InitializePrecheckedItemsMessageName = "InitializePrecheckedItems";
        public static readonly string TreeViewCheckedItemsCollectionChangedMessageName = "TreeViewCheckedItemsCollectionChanged";

        public ICommand CheckItem0Command
        {
            get; set;
        }

        public ICommand UncheckItem0Command
        {
            get; set;
        }

        public ObservableCollection<BusinessItem> CheckedItems
        {
            get; set;
        }

        public ObservableCollection<BusinessItem> ItemsSource
        {
            get; set;
        }

        public ViewModel()
        {
            this.CheckedItems = new ObservableCollection<BusinessItem>();
            this.CheckItem0Command = new Command(this.CheckItem0CommandExecute);
            this.UncheckItem0Command = new Command(this.UncheckItem0CommandExecute);
            MessagingCenter.Subscribe<BindableObject, NotifyCollectionChangedEventArgs>(this, ViewModel.TreeViewCheckedItemsCollectionChangedMessageName, (sender, args) => this.OnTreeViewCollectionChanged(sender, args));
        }

        public ViewModel(int rootItemsCount, int secondLevelItemsCount) :
            this()
        {
            this.ItemsSource = this.GetData(rootItemsCount, secondLevelItemsCount);
            this.SetInitiallyCheckedItems();
        }

        private void OnTreeViewCollectionChanged(BindableObject sender, NotifyCollectionChangedEventArgs args)
        {
            if (args.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in args.NewItems)
                {
                    if (!this.CheckedItems.Contains(item))
                    {
                        this.CheckedItems.Add((BusinessItem)item);
                    }
                }
            }
            else if (args.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in args.OldItems)
                {
                    this.CheckedItems.Remove((BusinessItem)item);
                }
            }
        }

        private void UncheckItem0CommandExecute(object obj)
        {
            var itemToUncheck = this.ItemsSource.FirstOrDefault();
            if (itemToUncheck != null)
            {
                this.CheckedItems.Remove(itemToUncheck);
                MessagingCenter.Send(this, ViewModel.ItemUncheckedMessageName, itemToUncheck);
            }
        }

        private void SetInitiallyCheckedItems()
        {
            this.CheckedItems.Add(this.ItemsSource[2].Children[3]);
            this.CheckedItems.Add(this.ItemsSource[1].Children[0]);
            MessagingCenter.Send<ViewModel, IEnumerable>(this, ViewModel.InitializePrecheckedItemsMessageName, this.CheckedItems);
        }

        private void CheckItem0CommandExecute(object obj)
        {
            var itemToCheck = this.ItemsSource.FirstOrDefault();
            if (itemToCheck != null)
            {
                this.CheckedItems.Add(itemToCheck);
                MessagingCenter.Send(this, ViewModel.ItemCheckedMessageName, itemToCheck);
            }
        }

        private ObservableCollection<BusinessItem> GetData(int rootItemsCount, int secondLevelItemsCount)
        {
            var result = new ObservableCollection<BusinessItem>();
            for (int i = 0; i < rootItemsCount; i++)
            {
                result.Add(new BusinessItem($"Item {i}"));
                for (int j = 0; j < secondLevelItemsCount; j++)
                {
                    result[i].Children.Add(new BusinessItem($"Item {i}.{j}"));
                }
            }
            return result;
        }
    }
}
