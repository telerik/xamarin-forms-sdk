using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.StyleSelectorExample
{
    public class ExampleListViewStyleSelector : ListViewStyleSelector
    {
        protected override void OnSelectStyle(object item, ListViewStyleContext styleContext)
        {
            var style = new ListViewItemStyle();
            styleContext.ItemStyle = style;
            styleContext.SelectedItemStyle = new ListViewItemStyle
            {
                BackgroundColor = Color.Gray,
                BorderColor = Color.Red,
                BorderWidth = 2
            };

            var sourceItem = item as SourceItem;
            if (sourceItem.Age < 18)
            {
                styleContext.ItemStyle.BackgroundColor = Color.Blue;
            }
            else if (sourceItem.Age < 65)
            {
                styleContext.ItemStyle.BackgroundColor = Color.Green;
            }
        }
    }
}
