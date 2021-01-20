using System;
using System.IO;
using System.Linq;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.PickerPopupPlacementExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPopupPlacement : ContentView
    {
        private AndroidSpecific.WindowSoftInputModeAdjust lastInputMode = AndroidSpecific.WindowSoftInputModeAdjust.Unspecified;

        public PickerPopupPlacement()
        {
            this.InitializeComponent();

            Func<Stream> streamFunc = () =>
            {
                var assembly = typeof(PickerPopupPlacement).Assembly;
                var fileName = assembly.GetManifestResourceNames()
                                       .FirstOrDefault(resourceName => resourceName.Contains("richtexteditor-htmlsource.html"));

                return assembly.GetManifestResourceStream(fileName);
            };

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
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
    }
}
