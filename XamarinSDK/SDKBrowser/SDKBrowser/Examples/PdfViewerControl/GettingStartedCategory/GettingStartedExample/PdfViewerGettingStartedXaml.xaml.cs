using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdfViewerGettingStartedXaml : ContentView
    {
        public PdfViewerGettingStartedXaml ()
        {
            InitializeComponent ();

            // >> pdfviewer-getting-started
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(PdfViewerGettingStartedXaml).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });
            this.pdfViewer.Source = streamFunc;
            // << pdfviewer-getting-started
        }
    }
}