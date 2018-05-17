using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ButtonControl.FeaturesCategory.ContentAlignmentExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentAlignment : ContentView
    {
        public ContentAlignment()
        {
            this.InitializeComponent();
        }

        private void Horizontal_Left(object sender, System.EventArgs e)
        {
            rb.HorizontalContentAlignment = Xamarin.Forms.TextAlignment.Start;
        }

        private void Horizontal_Center(object sender, System.EventArgs e)
        {
            rb.HorizontalContentAlignment = Xamarin.Forms.TextAlignment.Center;
        }

        private void Horizontal_Right(object sender, System.EventArgs e)
        {
            rb.HorizontalContentAlignment = Xamarin.Forms.TextAlignment.End;
        }

        private void Vertical_Top(object sender, System.EventArgs e)
        {
            rb.VerticalContentAlignment = Xamarin.Forms.TextAlignment.Start;
        }

        private void Vertical_Center(object sender, System.EventArgs e)
        {
            rb.VerticalContentAlignment = Xamarin.Forms.TextAlignment.Center;
        }

        private void Vertical_Bottom(object sender, System.EventArgs e)
        {
            rb.VerticalContentAlignment = Xamarin.Forms.TextAlignment.End;
        }
    }
}