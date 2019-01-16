using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.CommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Commands : ContentView
    {
        public Commands ()
        {
            InitializeComponent ();

            // >> pdfviewer-commands
            Assembly assembly = typeof(Commands).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            this.pdfViewer.Source = assembly.GetManifestResourceStream(fileName);
            // << pdfviewer-commands
        }
    }
}