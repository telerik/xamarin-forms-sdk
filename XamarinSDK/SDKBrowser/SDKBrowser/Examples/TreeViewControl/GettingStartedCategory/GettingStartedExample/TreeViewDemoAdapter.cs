using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.TreeViewControl.GettingStartedCategory.GettingStartedExample
{
    public class TreeViewDemoAdapter : IHierarchyAdapter
    {
        public object GetItemAt(object item, int index)
        {
            return (item as Item).Children[index];
        }

        public IEnumerable<object> GetItems(object item)
        {
            return (item as Item).Children ?? Enumerable.Empty<object>();
        }
    }
}
