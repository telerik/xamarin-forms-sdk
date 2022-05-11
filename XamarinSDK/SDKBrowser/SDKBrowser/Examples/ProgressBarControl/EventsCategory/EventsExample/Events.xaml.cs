using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ProgressBarControl.EventsCategory.EventsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentView
    {
        public Events()
        {
            InitializeComponent();
        }

        // >> progressbar-progresschanged-event
        private void OnProgressChanged(object sender, Telerik.XamarinForms.Primitives.ProgressBar.ProgressChangedEventArgs e)
        {
            this.statusLabel.Text = e.Progress.ToString();
        }
        // << progressbar-progresschanged-event

        // >> progressbar-progresscompleted-event
        private void OnProgressCompleted(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Completed";
        }
        // << progressbar-progresscompleted-event
    }
}