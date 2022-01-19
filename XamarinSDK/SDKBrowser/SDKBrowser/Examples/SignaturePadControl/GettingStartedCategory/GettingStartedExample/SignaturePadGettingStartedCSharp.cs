using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SignaturePadControl.GettingStartedCategory.GettingStartedExample
{
    public class SignaturePadGettingStartedCSharp : ContentView
    {
        public SignaturePadGettingStartedCSharp()
        {
            var grid = new Grid();

            // >> signaturepad-getting-started-csharp
            var signaturePad = new RadSignaturePad
            {
                BorderColor = Color.LightGray,
                BorderThickness = new Thickness(1)
            };
            // << signaturepad-getting-started-csharp
            
            grid.Children.Add(signaturePad);
            this.Content = grid;
        }
    }
}