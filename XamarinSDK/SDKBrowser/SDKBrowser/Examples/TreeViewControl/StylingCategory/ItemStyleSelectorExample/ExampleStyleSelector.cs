using Telerik.XamarinForms.DataControls.TreeView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleSelectorExample
{
    // >> treeview-examplestyleselector
    public class ExampleStyleSelector : TreeViewStyleSelector
    {       
        protected override void OnSelectStyle(object item, TreeViewStyleContext styleContext)
        {
            var dataItem = item as TreeViewDataItem;

            if (dataItem != null)
            {
                var style = new TreeViewItemStyle();
                if (dataItem.IsLeaf == true)
                {
                    style.BackgroundColor = Color.FromHex("#96CCFF");
                    style.BorderColor = Color.FromHex("#0A3A82");
                    style.BorderLocation = Telerik.XamarinForms.Common.Location.All;
                    style.BorderWidth =5 ;
                }
                else
                {
                    style.BackgroundColor = Color.FromHex("#356BFF");
                    style.BorderColor = Color.FromHex("#96CCFF");
                    style.BorderLocation = Telerik.XamarinForms.Common.Location.All;
                    style.BorderWidth = 5;
                }
                styleContext.ItemStyle = style;
            }
        }
    }
    // << treeview-examplestyleselector
}