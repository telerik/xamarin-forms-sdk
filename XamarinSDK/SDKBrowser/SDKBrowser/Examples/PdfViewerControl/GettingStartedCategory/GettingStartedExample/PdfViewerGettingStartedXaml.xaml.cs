using System.Linq;
using System.Reflection;
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
            Assembly assembly = typeof(PdfViewerGettingStartedXaml).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            if (!string.IsNullOrEmpty(fileName))
            {
                this.pdfViewer.Source = assembly.GetManifestResourceStream(fileName);
            }
            // << pdfviewer-getting-started
        }
    }
}