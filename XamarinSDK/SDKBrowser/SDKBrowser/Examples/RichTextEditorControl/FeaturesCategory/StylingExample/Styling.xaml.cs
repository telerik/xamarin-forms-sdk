using SDKBrowser.Behaviors;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.StylingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Styling : Xamarin.Forms.ContentView
    {
        private WindowSoftInputModeAdjust lastInputMode = WindowSoftInputModeAdjust.Unspecified;

        public Styling()
        {
            InitializeComponent();

            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(Styling).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("richtexteditor-htmlsource.html"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
            this.richTextEditor.Behaviors.Add(new PickImageBehavior());
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.Android)
            {
                if (this.Parent != null)
                {
                    if (this.lastInputMode == WindowSoftInputModeAdjust.Unspecified)
                    {
                        this.lastInputMode = GetSoftInputMode();
                    }

                    SetSoftInputMode(WindowSoftInputModeAdjust.Resize);
                }
                else
                {
                    SetSoftInputMode(this.lastInputMode);
                }
            }
        }

        private static WindowSoftInputModeAdjust GetSoftInputMode()
        {
            return Application.GetWindowSoftInputModeAdjust(Xamarin.Forms.Application.Current);
        }

        private static void SetSoftInputMode(WindowSoftInputModeAdjust inputMode)
        {
            Application.SetWindowSoftInputModeAdjust(Xamarin.Forms.Application.Current, inputMode);
        }
    }
}