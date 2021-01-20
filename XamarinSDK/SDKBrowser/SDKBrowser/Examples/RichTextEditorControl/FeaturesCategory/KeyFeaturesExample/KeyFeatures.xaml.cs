using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.XamarinForms.Primitives;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            InitializeComponent();
                    
            // >> richtexteditor-keyfeatures-fromstream
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(KeyFeatures).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("richtexteditor-htmlsource.html"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.richTextEditor.Source = RichTextSource.FromStream(streamFunc);
            // << richtexteditor-keyfeatures-fromstream
        }

        private async void GetHTML_Clicked(object sender, EventArgs e)
        {
            // >> richtexteditor-keyfeatures-gethtml
            var htmlString = await this.richTextEditor.GetHtmlAsync();
            // << richtexteditor-keyfeatures-gethtml

            await Application.Current.MainPage.DisplayAlert("Html content", htmlString, "OK");
        }
    }
}