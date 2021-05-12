using Telerik.Barcode;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BarcodeControl.SwissQRCodeCategory.SwissQRCodeExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwissQRCode : ContentView
    {
        public SwissQRCode()
        {
            InitializeComponent();

            // >> swissqrbarcode-example-builder
            SwissQRCodeValueStringBuilder qrCodeValue = new SwissQRCodeValueStringBuilder(
                  new Iban("CH4431999123000889012", IbanType.QRIBAN),
                  SwissQRCodeCurrency.EUR,
                  new Contact("Max Muster & Söhne",
                  new StructuredAddress("CH", "8000", "Seldwyla", "Musterstrasse", "123")),
                  new Reference(ReferenceType.QRR, "210000000003139471430009017"),
                  new AdditionalInformation("Order from 15.03.2021", "//S1/10/1234/11/201021/30/102673386/32/7.7/40/0:30"),
                  new Contact("Simon Muster", new StructuredAddress("CH", "8000", "Seldwyla", "Musterstrasse", "1")),
                  (decimal)1949.75,
                  new AlternativeProcedure("Name AV1: UV;UltraPay005;12345", "Name AV2: XY;XYService;54321"));
            // << swissqrbarcode-example-builder

            // >> swissqrbarcode-example-validate
            string errors = qrCodeValue.Validate();

            if (string.IsNullOrEmpty(errors))
            {
                this.Barcode.Value = qrCodeValue.BuildValue();
            }
            // << swissqrbarcode-example-validate
        }
    }
}
