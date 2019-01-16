using System;
using System.Collections;
using System.Collections.Specialized;
using Telerik.XamarinForms.DataControls;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.PrecheckedItemsExample
{
    public class TreeViewBehavior : Behavior<RadTreeView>
    {
        private bool isOwnerFullyLoaded = false;
        private IEnumerable precheckedItemsCache = null;
        private WeakReference owner;

        private RadTreeView Owner
        {
            get
            {
                if (owner.IsAlive)
                {
                    return (RadTreeView)owner.Target;
                }
                return null;
            }
        }

        protected override void OnAttachedTo(RadTreeView bindable)
        {
            base.OnAttachedTo(bindable);
            this.owner = new WeakReference(bindable);
            this.Owner.NativeControlLoaded += Owner_NativeControlLoaded;
            this.Owner.CheckedItems.CollectionChanged += CheckedItems_CollectionChanged;
            MessagingCenter.Subscribe<ViewModel, BusinessItem>(this, ViewModel.ItemCheckedMessageName, (sender, args) => this.OnItemChecked(sender, args));
            MessagingCenter.Subscribe<ViewModel, BusinessItem>(this, ViewModel.ItemUncheckedMessageName, (sender, args) => this.OnItemUnchecked(sender, args));
            MessagingCenter.Subscribe<ViewModel, IEnumerable>(this, ViewModel.InitializePrecheckedItemsMessageName, (sender, args) => this.OnItemsPrecheckedInit(sender, args));
        }

        protected override void OnDetachingFrom(RadTreeView bindable)
        {
            this.Owner.NativeControlLoaded -= Owner_NativeControlLoaded;
            this.Owner.CheckedItems.CollectionChanged -= CheckedItems_CollectionChanged;
            this.owner = null;
            MessagingCenter.Unsubscribe<ViewModel, BusinessItem>(this, ViewModel.ItemCheckedMessageName);
            MessagingCenter.Unsubscribe<ViewModel, BusinessItem>(this, ViewModel.ItemUncheckedMessageName);
            MessagingCenter.Unsubscribe<ViewModel, IEnumerable>(this, ViewModel.InitializePrecheckedItemsMessageName);
            base.OnDetachingFrom(bindable);
        }

        private void CheckedItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            MessagingCenter.Send<BindableObject, NotifyCollectionChangedEventArgs>(this, ViewModel.TreeViewCheckedItemsCollectionChangedMessageName, e);
        }

        private void OnItemsPrecheckedInit(ViewModel sender, IEnumerable precheckedItems)
        {
            if (this.Owner == null)
                return;

            if (this.isOwnerFullyLoaded)
            {
                this.CheckItems(precheckedItems);
            }
            else
            {
                // postpone the checking till the UI containers are created
                // otherwise there will be nothing to check
                // and prechecking will fail
                this.precheckedItemsCache = precheckedItems;
            }
        }

        private void OnItemUnchecked(ViewModel sender, BusinessItem args)
        {
            this.Owner?.UncheckItem(args);
        }

        private void OnItemChecked(ViewModel sender, BusinessItem args)
        {
            this.Owner?.CheckItem(args);
        }

        private void CheckItems(IEnumerable itemsToCheck)
        {
            foreach (var item in itemsToCheck)
            {
                this.OnItemChecked(null, (BusinessItem)item);
            }
        }

        private void Owner_NativeControlLoaded(object sender, EventArgs e)
        {
            this.isOwnerFullyLoaded = true;
            if (this.precheckedItemsCache != null)
            {
                this.CheckItems(this.precheckedItemsCache);
                this.precheckedItemsCache = null;
            }
        }
    }
}