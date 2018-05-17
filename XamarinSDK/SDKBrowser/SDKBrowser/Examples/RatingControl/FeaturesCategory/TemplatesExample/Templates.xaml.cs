using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.RatingControl.FeaturesCategory.TemplatesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Templates : ContentView
    {
        public Templates()
        {
            this.InitializeComponent();
        }

        private void RadTemplatedRating_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.label.Text = "Value is changed to: " + e.NewValue;
        }
    }
}