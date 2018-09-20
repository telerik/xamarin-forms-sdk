using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.ItemTemplateSelectorExample
{
    // >> slideview-itemtemplateselector-viewmodel
    public class ViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public ViewModel()
        {
            this.Products = new ObservableCollection<Product>()
            {
                new Product() {Name="Product 1", Price = 21.5, InStock = true},
                new Product() {Name="Product 2", Price = 44.3, InStock = false},
                new Product() {Name="Product 3", Price = 33, InStock = true}
            };
        }
    }
    // << slideview-itemtemplateselector-viewmodel
}
