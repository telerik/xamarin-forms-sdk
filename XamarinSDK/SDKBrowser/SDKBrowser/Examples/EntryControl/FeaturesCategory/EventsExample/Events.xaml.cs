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
            this.entry.TextChanged += Entry_TextChanged;
            this.entry.Completed += Entry_Completed;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            this.textChangedLabel.Text = "User completed entering text";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textChangedLabel.Text = $"Text changed from {e.OldTextValue} to {e.NewTextValue}";
        }
    }
}