using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.XamarinForms.PdfViewer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.ViewportSettingsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewportSettings : ContentView
    {
        private Rectangle initialViewport;
        public ViewportSettings()
        {
            InitializeComponent();

            // >> pdfviewer-viewport-code
            Func<CancellationToken, Task<Stream>> streamFunc = ct => Task.Run(() =>
            {
                Assembly assembly = typeof(ViewportSettings).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                Stream stream = assembly.GetManifestResourceStream(fileName);
                return stream;
            });
            this.pdfViewer.Source = streamFunc;
            // << pdfviewer-viewport-code

            this.pdfViewer.PropertyChanged += PdfViewer_PropertyChanged;          
        }

        private void PdfViewer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this.pdfViewer.Viewport) && this.pdfViewer.Document != null)
            {
                this.initialViewport = this.pdfViewer.Viewport;

                this.pdfViewer.PropertyChanged -= PdfViewer_PropertyChanged;
            }
        }

        private void GetCurrentViewport(object sender, EventArgs e)
        {
            // >> pdfviewer-viewport-getviewport
            var viewport = this.pdfViewer.Viewport;
            var viewportMessage = String.Format("Current viewport with Width: {0:0.00}, Height: {1:0.00}, Left: {2:0.00}, Top: {3:0.00}", viewport.Width, viewport.Height, viewport.X, viewport.Y);
            Application.Current.MainPage.DisplayAlert("Current Viewport", viewportMessage, "OK");
            // << pdfviewer-viewport-getviewport
        }

        private void ChangeViewport(object sender, EventArgs e)
        {
            // >> pdfviewer-viewport-setviewport
            RadFixedDocument document = this.pdfViewer.Document;
            var currentViewport = this.pdfViewer.Viewport;

            if (this.pdfViewer.LayoutMode == LayoutMode.ContinuousScroll)
            {               
                double pagesHeight = 0;

                for (int i = 0; i < document.Pages.Count - 1; i++)
                {
                    pagesHeight += document.Pages[i].Size.Height;
                    pagesHeight += this.pdfViewer.PageSpacing;
                }               
                this.pdfViewer.ChangeViewport(new Rectangle(0, pagesHeight, currentViewport.Width, currentViewport.Height));
            }
            else
            {
                this.pdfViewer.NavigateToPage(document.Pages.Count - 1);
                this.pdfViewer.ChangeViewport(new Rectangle(0, 0, currentViewport.Width, currentViewport.Height));
            }
            // << pdfviewer-viewport-setviewport
        }

        private void ResetViewport(object sender, EventArgs e)
        {
            this.pdfViewer.ChangeViewport(initialViewport);
        }
    }
}