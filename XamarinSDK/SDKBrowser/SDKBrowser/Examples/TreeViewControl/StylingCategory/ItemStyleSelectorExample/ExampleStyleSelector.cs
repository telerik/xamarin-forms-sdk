using Telerik.XamarinForms.DataControls.TreeView;
using Xamarin.Forms;
using T = Telerik.XamarinForms.DataControls.TreeView;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleSelectorExample
{
    public class ExampleStyleSelector : T.TreeViewStyleSelector
    {
        protected override void OnSelectStyle(object item, T.TreeViewStyleContext styleContext)
        {
            var dataItem = item as TreeViewDataItem;

            if (dataItem != null)
            {
                var style = new T.TreeViewItemStyle();
                if (dataItem.Header.Contains("2"))
                {
                    style.BackgroundColor = Color.Orange;
                    style.BorderColor = Color.Red;
                    style.BorderLocation = Telerik.XamarinForms.Common.Location.Bottom;
                    style.BorderWidth = 5;
                }
                else if(dataItem.Header.Contains("3"))
                {
                    style.BackgroundColor = Color.DeepSkyBlue;
                    style.BorderColor = Color.Cyan;
                    style.BorderLocation = Telerik.XamarinForms.Common.Location.Top;
                    style.BorderWidth = 5;
                }
                else if (dataItem.Header.Contains("1"))
                {
                    style.BackgroundColor = Color.LimeGreen;
                    style.BorderColor = Color.LightGreen;
                    style.BorderLocation = Telerik.XamarinForms.Common.Location.All;
                    style.BorderWidth = 3;
                }

                styleContext.ItemStyle = style;
            }
        }
    }
}