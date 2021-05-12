using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BadgeViewControl.FeaturesCategory.BadgeViewContentExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // >> badgeview-content-code-behind
    public partial class BadgeViewContent : ContentView
    {
        private int badgeCounter = 0;

        public BadgeViewContent()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            badgeCounter++;
            badgeView.BadgeText = badgeCounter.ToString();
        }
    }
    // << badgeview-content-code-behind
}