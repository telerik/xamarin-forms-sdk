using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.PdfToolbarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdfToolbar : ContentView
    {
        public PdfToolbar()
        {
            InitializeComponent();

            // >> pdfviewer-toolbar
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(PdfToolbar).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });
            this.pdfViewer.Source = streamFunc;
            // << pdfviewer-toolbar
        }
    }
}