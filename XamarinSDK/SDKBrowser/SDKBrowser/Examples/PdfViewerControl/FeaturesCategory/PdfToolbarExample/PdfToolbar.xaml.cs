using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.PdfToolbarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdfToolbar : ContentView
    {
        public PdfToolbar ()
        {
            InitializeComponent ();

            // >> pdfviewer-toolbar
            Assembly assembly = typeof(PdfToolbar).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            this.pdfViewer.Source = assembly.GetManifestResourceStream(fileName);
            // << pdfviewer-toolbar
        }
    }
}