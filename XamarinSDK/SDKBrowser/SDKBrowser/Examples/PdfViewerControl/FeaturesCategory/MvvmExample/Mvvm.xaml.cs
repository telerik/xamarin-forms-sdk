using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.MvvmExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mvvm : ContentView
    {
        public Mvvm()
        {
            InitializeComponent ();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == "Renderer")
            {
                MessagingCenter.Unsubscribe<MvvmViewModel>(this, MvvmViewModel.ResetZoomMessage);
                object renderer = RadPlatform.GetRendererObject(this);
                if (renderer != null)
                {
                    MessagingCenter.Subscribe<MvvmViewModel>(this, MvvmViewModel.ResetZoomMessage, this.OnResetZoom);
                }
            }
        }

        private void OnResetZoom(MvvmViewModel obj)
        {
            this.pdfViewer.ZoomToLevel(1);
        }
    }
}