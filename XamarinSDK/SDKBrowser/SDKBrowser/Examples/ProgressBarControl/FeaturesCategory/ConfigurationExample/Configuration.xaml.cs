using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ProgressBarControl.FeaturesCategory.ConfigurationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuration : ContentView
    {
        public Configuration()
        {
            InitializeComponent();
        }

        // >> progressbar-configuration-valueupdated
        private void ProgressBarUpdateClicked(object sender, EventArgs e)
        {
            this.progressBar.Value = 75;
        }
        // << progressbar-configuration-valueupdated
    }
}