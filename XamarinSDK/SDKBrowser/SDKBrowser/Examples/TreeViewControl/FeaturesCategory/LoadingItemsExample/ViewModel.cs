using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataControls.TreeView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.LoadingItemsExample
{
    // >> treeview-loadondemand-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        public ObservableCollection<Category> Source { get; set; }
        public ICommand LoadOnDemandCommand
        {
            get; set;
        }
        public ViewModel()
        {
            this.Source = new ObservableCollection<Category>()
            {
                new Category { Name = "Products"},
                new Category { Name = "Purchase"},
                new Category { Name = "Support"},
                new Category { Name = "Community"}
            };

            this.LoadOnDemandCommand = new Command(async (p) => await this.LoadOnDemandExecute(p), (p) => this.IsLoadOnDemandEnabled(p));
        }
        private bool IsLoadOnDemandEnabled(object p)
        {
            var context = (TreeViewLoadOnDemandCommandContext)p;
            return context.Item is Category;
        }
        async private Task LoadOnDemandExecute(object p)
        {
            var context = (TreeViewLoadOnDemandCommandContext)p;
            var category = context.Item as Category;
            if (category != null)
            {
                ObservableCollection<string> children = await Task.Run(() => this.LoadChildren(category));
                category.Children = children;
                context.Finish();
            }
        }
        private ObservableCollection<string> LoadChildren(Category category)
        {
            Task.Delay(1000).Wait();

            Dictionary<string, ObservableCollection<string>> allItems = new Dictionary<string, ObservableCollection<string>>();
            allItems.Add("Products", new ObservableCollection<string>() { "Telerik UI for Xamarin", "Telerik UI for WPF", "Telerik Reporting" });
            allItems.Add("Purchase", new ObservableCollection<string>() { "Buy now", "License Agreement", "Policies" });
            allItems.Add("Support", new ObservableCollection<string>() { "Support Center", "Knowledge Base", "Demos", "Tutorials" });
            allItems.Add("Community", new ObservableCollection<string>() { "Learning Resources", "Blogs", "Forums" });

            var result = new ObservableCollection<string>();
            bool hasChildren = allItems.TryGetValue(category.Name, out result);

            return result;
        }
        // << treeview-loadondemand-viewmodel
    }
}