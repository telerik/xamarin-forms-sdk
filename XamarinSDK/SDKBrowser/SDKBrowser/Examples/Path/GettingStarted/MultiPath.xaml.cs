using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Path
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiPath : ContentPage
    {
        public MultiPath()
        {
            this.InitializeComponent();

            this.root.SizeChanged += Root_SizeChanged;
        }

        private void Root_SizeChanged(object sender, System.EventArgs e)
        {
            double size = Math.Min(this.root.Width, this.root.Height / 2);
            this.path1.WidthRequest = size;
            this.path1.HeightRequest = size;
            this.path2.WidthRequest = size;
            this.path2.HeightRequest = size;
        }
    }
}