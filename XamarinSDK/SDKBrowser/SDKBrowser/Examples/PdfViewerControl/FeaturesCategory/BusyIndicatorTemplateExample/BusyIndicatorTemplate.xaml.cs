using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.BusyIndicatorTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusyIndicatorTemplate : ContentView
    {
        public BusyIndicatorTemplate ()
        {
            InitializeComponent ();

            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(BusyIndicatorTemplate).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });

            this.pdfViewer.Source = streamFunc;
        }
    }
}