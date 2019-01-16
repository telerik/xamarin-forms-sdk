using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ExpandCollapseExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewExpandCollapse : ContentView
    {
        public TreeViewExpandCollapse ()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
        // >> treeview-expandcollapse-item
        private void ExpandItem2(object sender, EventArgs e)
        {
            var item2 = (treeView.ItemsSource as IList<Item>)[1];
            treeView.Expand(item2);
        }      
        private void CollapseItem2(object sender, EventArgs e)
        {
            var item2 = (treeView.ItemsSource as IList<Item>)[1];
            treeView.Collapse(item2);
        }
        // << treeview-expandcollapse-item
        private void ExpandItem22(object sender, EventArgs e)
        {
            var item22 = ((treeView.ItemsSource as IList<Item>)[1].Children as IList<Item>)[1];
            treeView.Expand(item22);
        }
        private void CollapseItem22(object sender, EventArgs e)
        {
            var item22 = ((treeView.ItemsSource as IList<Item>)[1].Children as IList<Item>)[1];
            treeView.Collapse(item22);
        }
        // >> treeview-expandcollapse-all
        private void ExpandAll(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }
        private void CollapseAll(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }
        // << treeview-expandcollapse-all
    }
}