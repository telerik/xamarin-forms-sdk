using System;
using System.Linq;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.RemoteSearchExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // >> autocompleteview-remote-search
    public partial class RemoteSearch : ContentView
    {
        private ViewModel viewModel;
        private string currentText;
        private bool  isRemoteSearchRunning;

        public RemoteSearch()
        {
            InitializeComponent();

            this.viewModel = new ViewModel();
            this.BindingContext = viewModel;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var autoCompleteView = (RadAutoCompleteView)sender;
            autoCompleteView.ItemsSource = null;

            this.currentText = e.NewTextValue ?? "";

            if (this.currentText.Length >= autoCompleteView.SearchThreshold && !this.isRemoteSearchRunning)
            {
                this.isRemoteSearchRunning = true;
                Device.StartTimer(TimeSpan.FromMilliseconds(1500), () =>
                {
                    this.isRemoteSearchRunning = false;
                    string searchText = this.currentText.ToLower();
                    autoCompleteView.ItemsSource = this.viewModel.Source.Where(i => i.Name.ToLower().Contains(searchText));
                    return false;
                });
            }
        }
    }
    // << autocompleteview-remote-search
}
