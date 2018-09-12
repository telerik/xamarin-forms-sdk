using Xamarin.Forms;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.ItemTemplateSelectorExample
{
    // >> slideview-itemtemplateselector-selectordefinition
    public class SlideViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InStockTemplate { get; set; }
        public DataTemplate NotAvailableTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Product;
            if (product != null && product.InStock)
                return InStockTemplate;
            else return NotAvailableTemplate;
        }
    }
    // << slideview-itemtemplateselector-selectordefinition
}
