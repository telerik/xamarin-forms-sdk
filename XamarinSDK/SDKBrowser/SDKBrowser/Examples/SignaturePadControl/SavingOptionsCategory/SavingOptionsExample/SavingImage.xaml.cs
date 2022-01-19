using System;
using System.IO;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SignaturePadControl.SavingOptionsCategory.SavingOptionsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavingImage : ContentView
    {
        public SavingImage()
        {
            InitializeComponent();
        }

        private async void GetJPEG_Clicked(object sender, EventArgs e)
        {
            // >> signaturepad-saving-image-method
            var settings = new SaveImageSettings()
            {
                ImageFormat = ImageFormat.Jpeg,
                ScaleFactor = 0.7,
                ImageQuality = 1,
                BackgroundColor = Color.LightGray,
                StrokeColor = Color.DarkBlue,
                StrokeThickness = 5
            };

            byte[] array;

            using (var stream = new MemoryStream())
            {
                await this.signaturePad.SaveImageAsync(stream, settings);
                array = stream.ToArray();

                this.signatureImage.Source = ImageSource.FromStream(() => new MemoryStream(array));
            }
            // << signaturepad-saving-image-method
        }

        private async void GetPNG_Clicked(object sender, EventArgs e)
        {
            var settings = new SaveImageSettings()
            {
                ImageFormat = ImageFormat.Png,               
                BackgroundColor = Color.LightGray,
                StrokeColor = Color.DarkRed,
                StrokeThickness = 5
            };

            byte[] array;

            using (var stream = new MemoryStream())
            {
                await this.signaturePad.SaveImageAsync(stream, settings);
                array = stream.ToArray();

                this.signatureImage.Source = ImageSource.FromStream(() => new MemoryStream(array));
            }
        }
    }
}