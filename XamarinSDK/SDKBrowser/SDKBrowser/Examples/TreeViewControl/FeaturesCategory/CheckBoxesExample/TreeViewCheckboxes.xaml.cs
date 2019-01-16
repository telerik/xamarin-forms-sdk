using System;
using System.Collections.Generic;
using Telerik.XamarinForms.DataControls.TreeView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.CheckBoxesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewCheckboxes : ContentView
    {
        public TreeViewCheckboxes()
        {
            InitializeComponent ();
            this.BindingContext = new ViewModel();

            // >> treeview-checkeditems-collection
            treeView.CheckedItems.CollectionChanged += CheckedItems_CollectionChanged;
            // << treeview-checkeditems-collection
            CheckFirstItem();
        }

        // >> treeview-checkeditems-collectionchanged
        private void CheckedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var ci = this.treeView.CheckedItems as CheckedItemsCollection;
            this.CheckedItemsCount.Text = ci.Count.ToString();
        }
        // << treeview-checkeditems-collectionchanged

        public void Clicked(object sender, EventArgs e)
        {
            if (this.treeView.CheckBoxMode == CheckBoxModes.None)
            {
                this.treeView.CheckBoxMode = CheckBoxModes.Individual;
            }
            else if (this.treeView.CheckBoxMode == CheckBoxModes.Individual)
            {
                this.treeView.CheckBoxMode = CheckBoxModes.Propagate;
            }
            else
            {
                this.treeView.CheckBoxMode = CheckBoxModes.None;
            }
        }

        // >> treeview-check-uncheck-item
        private void CheckFirstItem()
        {
            var firstItem = (treeView.ItemsSource as IList<Item>)[0];
            treeView.CheckItem(firstItem);
        }

        private void UncheckFirstItem()
        {
            var firstItem = (treeView.ItemsSource as IList<Item>)[0];
            treeView.UncheckItem(firstItem);
        }
        // << treeview-check-uncheck-item
    }
}