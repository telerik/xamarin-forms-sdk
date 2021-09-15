using Plugin.Media;
using Plugin.Media.Abstractions;
using SDKBrowser.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;


namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.InsertImagesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertImages : ContentView
    {
        private AndroidSpecific.WindowSoftInputModeAdjust lastInputMode = AndroidSpecific.WindowSoftInputModeAdjust.Unspecified;

        public InsertImages()
        {
            InitializeComponent();

            // >> rte-insert-images-add-rte-source
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {

                Assembly assembly = typeof(InsertImages).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("PickYourHoliday.html"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
            // << rte-insert-images-add-rte-source
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (Device.RuntimePlatform == Device.Android)
            {
                if (this.Parent != null)
                {
                    if (this.lastInputMode == AndroidSpecific.WindowSoftInputModeAdjust.Unspecified)
                    {
                        this.lastInputMode = GetSoftInputMode();
                    }

                    SetSoftInputMode(AndroidSpecific.WindowSoftInputModeAdjust.Resize);
                }
                else
                {
                    SetSoftInputMode(this.lastInputMode);
                }
            }
        }

        private static AndroidSpecific.WindowSoftInputModeAdjust GetSoftInputMode()
        {
            return AndroidSpecific.Application.GetWindowSoftInputModeAdjust(Application.Current);
        }

        private static void SetSoftInputMode(AndroidSpecific.WindowSoftInputModeAdjust inputMode)
        {
            AndroidSpecific.Application.SetWindowSoftInputModeAdjust(Application.Current, inputMode);
        }

        // >> rte-insert-images-pick-image-implementation
        private async void OnPickImage(object sender, PickImageEventArgs eventArgs)
        {
            var mediaPlugin = CrossMedia.Current;

            if (mediaPlugin.IsPickPhotoSupported)
            {
                if (!await PermissionsHelper.RequestPhotosAccess())
                {
                    return;
                }

                if (!await PermissionsHelper.RequestStorrageAccess())
                {
                    return;
                }

                var mediaFile = await mediaPlugin.PickPhotoAsync();

                if (mediaFile != null)
                {
                    var imageSource = RichTextImageSource.FromFile(mediaFile.Path);
                    eventArgs.Accept(imageSource);
                    return;
                }
            }
            // << rte-insert-images-pick-image-implementation
        }
    }
}