using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Rating
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Templates : ContentPage
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void RadTemplatedRating_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.label.Text = "Value is changed to: " + e.NewValue;
        }
    }
}