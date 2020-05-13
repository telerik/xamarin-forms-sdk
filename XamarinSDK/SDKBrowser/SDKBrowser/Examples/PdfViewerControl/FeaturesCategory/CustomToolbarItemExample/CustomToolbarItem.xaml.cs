using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.CustomToolbarItemExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomToolbarItem : ContentView
    {
        public CustomToolbarItem()
        {
            InitializeComponent();
       
            // >> pdfviewer-toolbar-customcommand
            this.BindingContext = new ViewModel();

            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(CustomToolbarItem).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });
            this.pdfViewer.Source = streamFunc;           
            // << pdfviewer-toolbar-customcommand
        }
    }
}