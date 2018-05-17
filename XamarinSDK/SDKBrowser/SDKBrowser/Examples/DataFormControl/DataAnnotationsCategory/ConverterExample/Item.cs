using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ConverterExample
{
    // >> dataform-dataannotations-converter-source
    public class Item : NotifyPropertyChangedBase
    {
        decimal price;

        [DisplayOptions(Header = "Name")]
        public string Name { get; set; } = "vase";

        [DisplayOptions(Header = "Price")]
        [Converter(typeof(DecimalToDoublePropertyConverter))]
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
    // <<dataform-dataannotations-converter-source
}

