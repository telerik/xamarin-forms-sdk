using System.Linq;
using System.Reflection;
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

            Assembly assembly = typeof(BusyIndicatorTemplate).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            this.pdfViewer.Source = assembly.GetManifestResourceStream(fileName);
        }
    }
}