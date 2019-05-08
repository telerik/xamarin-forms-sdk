using System;
using Telerik.XamarinForms.PdfViewer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.SourceExceptionExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SourceException : ContentView
    {
        public SourceException()
        {
            InitializeComponent();

            this.pdfViewer.Source = new Uri("a.b.c", UriKind.Relative);
        }

        // >> pdfviewer-sourceexception-eventhandler
        private void PdfViewerSourceException(object sender, SourceExceptionEventArgs e)
        {
            var error = e.Exception.Message;
        }
        // << pdfviewer-sourceexception-eventhandler
    }
}