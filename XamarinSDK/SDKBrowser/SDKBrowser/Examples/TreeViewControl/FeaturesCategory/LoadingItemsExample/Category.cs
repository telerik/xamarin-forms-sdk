using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.LoadingItemsExample
{
    // >> treeview-loadondemand-businessobject
    public class Category : NotifyPropertyChangedBase
    {       
        public string Name { get; set; }
     
        ObservableCollection<string> children;
        public ObservableCollection<string> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                if (this.children != value)
                {
                    this.children = value;
                    this.OnPropertyChanged();
                }
            }
        }       
    }
    // << treeview-loadondemand-businessobject
}

