using Telerik.XamarinForms.Primitives;
using Telerik.XamarinForms.Primitives.SlideView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.EventsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentView
    {
        public Events()
        {
            InitializeComponent();
        }

        // >> slideview-events-code
        private void GoingToNextSlide(object sender, SlideViewSlidingToIndexEventArgs e)
        {
            var slideView = sender as RadSlideViewPresenter;
            if (slideView.SelectedIndex != -1)
                Application.Current.MainPage.DisplayAlert("", "You're going from Slide " + slideView.SelectedIndex + " to Slide " + e.Index, "OK");
        }
        // << slideview-events-code
    }
}