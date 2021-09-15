using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.CustomImagePickerExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomImagePicker : ContentView
    {
        private AndroidSpecific.WindowSoftInputModeAdjust lastInputMode = AndroidSpecific.WindowSoftInputModeAdjust.Unspecified;
        private Assembly currentAssembly = typeof(CustomImagePicker).Assembly;
        public CustomImagePicker()
        {
            InitializeComponent();

            // >> rte-custom-image-picker-initialize-images
            InitializeImages();
            // << rte-custom-image-picker-initialize-images

            // >> rte-custom-image-picker-html-document
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                string fileName = this.currentAssembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pick-image-demo.html"));
                Stream stream = this.currentAssembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
            // << rte-custom-image-picker-html-document
        }

        // >> rte-custom-image-picker-add-images-to-picker-toolbar-item
        private void InitializeImages()
        {
            var resourceNames = this.currentAssembly.GetManifestResourceNames();
            var imageSources = new List<RichTextImageSource>();

            foreach (var resourceName in resourceNames)
            {
                if (resourceName.Contains("emoji"))
                {
                    var imageSource = RichTextImageSource.FromStream(() =>
                        this.currentAssembly.GetManifestResourceStream(resourceName), RichTextImageType.Png);

                    imageSources.Add(imageSource);
                }
            }

            this.imagePicker.ItemsSource = imageSources;
        }
        // << rte-custom-image-picker-add-images-to-picker-toolbar-item

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
    }
}