using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.XamarinForms.PdfViewer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            InitializeComponent();

            // >> pdfviewer-key-features-source-uri
            Uri uri = this.GetUri();
            this.pdfViewer.Source = uri;
            this.pdfViewer.Source = new UriDocumentSource(uri);
            // << pdfviewer-key-features-source-uri

            // >> pdfviewer-key-features-source-byte
            byte[] bytes = this.GetBytes();
            this.pdfViewer.Source = bytes;
            this.pdfViewer.Source = new ByteArrayDocumentSource(bytes, true);
            // << pdfviewer-key-features-source-byte

            //this.ImportFixedDocument();

            // >> pdfviewer-key-features-stream
            Assembly assembly = typeof(KeyFeatures).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            Stream stream = assembly.GetManifestResourceStream(fileName);
            this.pdfViewer.Source = stream;
            // << pdfviewer-key-features-stream
        }

        // >> pdfviewer-key-features-source-fixed-method
        private void ImportFixedDocument()
        {
            Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider provider = new Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider();
            Assembly assembly = typeof(KeyFeatures).Assembly;
            string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
            using (Stream stream = assembly.GetManifestResourceStream(fileName))
            {
                RadFixedDocument document = provider.Import(stream);
                this.pdfViewer.Source = document;
                this.pdfViewer.Source = new FixedDocumentSource(document);
            }
        }
        // << pdfviewer-key-features-source-fixed-method

        private Uri GetUri()
        {
            return null;
        }

        private byte[] GetBytes()
        {
            return null;
        }
    }
}