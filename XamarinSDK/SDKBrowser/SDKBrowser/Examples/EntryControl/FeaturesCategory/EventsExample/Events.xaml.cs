using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryControl.FeaturesCategory.EventsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentView
    {
        public Events()
        {
            this.InitializeComponent();
        }

        // >> entry-completed-event
        private void Entry_Completed(object sender, EventArgs e)
        {
            this.textChangedLabel.Text = "User completed entering text";
        }
        // << entry-completed-event 

        // >> entry-textchanged-event 
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textChangedLabel.Text = $"Text changed from {e.OldTextValue} to {e.NewTextValue}";
        }
        // << entry-textchanged-event
    }
}