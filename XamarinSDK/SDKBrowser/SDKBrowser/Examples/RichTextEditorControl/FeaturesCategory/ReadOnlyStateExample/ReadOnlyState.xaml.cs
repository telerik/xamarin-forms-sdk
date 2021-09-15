using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using AndroidApplication = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.Application;
using SDKBrowser.Behaviors;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.ReadOnlyStateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReadOnlyState : ContentView
    {
        private WindowSoftInputModeAdjust lastInputMode = WindowSoftInputModeAdjust.Unspecified;

        public ReadOnlyState()
        {
            InitializeComponent();
            // >> richtexteditor-readonly-state-code-behind
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(ReadOnlyState).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("richtexteditor-htmlsource.html"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
            // << richtexteditor-readonly-state-code-behind

            this.richTextEditor.Behaviors.Add(new PickImageBehavior());
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (Device.RuntimePlatform == Device.Android)
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
            return AndroidApplication.GetWindowSoftInputModeAdjust(Xamarin.Forms.Application.Current);
        }

        private static void SetSoftInputMode(WindowSoftInputModeAdjust inputMode)
        {
            AndroidApplication.SetWindowSoftInputModeAdjust(Xamarin.Forms.Application.Current, inputMode);
        }
    }
}