using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.TextSelectionExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextSelection : ContentView
	{
		public TextSelection ()
		{
			InitializeComponent ();

            // >> pdfviewer-features-textselection-setvm
            this.BindingContext = new ViewModel();
            // << pdfviewer-features-textselection-setvm

            // >> pdfviewer-features-textselection-code
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(TextSelection).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });
            this.pdfViewer.Source = streamFunc;
            // << pdfviewer-features-textselection-code
        }
    }
}