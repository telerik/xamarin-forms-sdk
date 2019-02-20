using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.MvvmExample
{
    public class MvvmViewModel : NotifyPropertyChangedBase
    {
        public const string ResetZoomMessage = "Reset PdfViewer Zoom Level";

        private Func<CancellationToken, Task<Stream>> stream;
        private ICommand resetZoomCommand;
        private ICommand zoomInCommand;
        private ICommand zoomOutCommand;

        public MvvmViewModel()
        {
            this.stream = token => Task.Run(() =>
            {
                Assembly assembly = typeof(MvvmViewModel).Assembly;
                string fileName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.Contains("pdfviewer-overview.pdf"));
                return assembly.GetManifestResourceStream(fileName);
            }, token);

            this.resetZoomCommand = new Command(this.ResetZoom);
        }

        public Func<CancellationToken, Task<Stream>> Stream
        {
            get { return this.stream; }
        }

        public ICommand ResetZoomCommand
        {
            get { return this.resetZoomCommand; }
        }

        public ICommand ZoomInCommand
        {
            get { return this.zoomInCommand; }
            set { this.UpdateValue(ref this.zoomInCommand, value); }
        }

        public ICommand ZoomOutCommand
        {
            get { return this.zoomOutCommand; }
            set { this.UpdateValue(ref this.zoomOutCommand, value); }
        }

        private void ResetZoom(object obj)
        {
            MessagingCenter.Send<MvvmViewModel>(this, ResetZoomMessage);
        }
    }
}
