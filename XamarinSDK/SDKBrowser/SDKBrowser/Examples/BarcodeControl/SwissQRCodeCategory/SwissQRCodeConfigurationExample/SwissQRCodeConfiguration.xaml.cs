using System;
using System.Linq;
using Telerik.Barcode;
using Telerik.XamarinForms.Barcode;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BarcodeControl.SwissQRCodeCategory.SwissQRCodeConfigurationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwissQRCodeConfiguration : ContentView
    {
        public SwissQRCodeConfiguration()
        {
            InitializeComponent();

            this.IbanType.ItemsSource = Enum.GetValues(typeof(IbanType)).Cast<IbanType>().Select(p => p.ToString()).ToList();
            this.Currency.ItemsSource = Enum.GetValues(typeof(SwissQRCodeCurrency)).Cast<SwissQRCodeCurrency>().Select(p => p.ToString()).ToList();
            this.ReferenceType.ItemsSource = Enum.GetValues(typeof(ReferenceType)).Cast<ReferenceType>().Select(p => p.ToString()).ToList();

            this.BindingContext = new SwissQRConfigurationViewModel();

            this.barcode.Symbology = new SwissQRCode();
        }
    }
}
