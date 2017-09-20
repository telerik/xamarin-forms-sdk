using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SDKBrowser.Examples.ListView.Styling.BindableSelectedItemStyle;

namespace SDKBrowser.Examples.ListView
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindableSelectedItemStyle : ContentPage
    {
        public BindableSelectedItemStyle()
        {
            InitializeComponent();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.BindingContext = new ViewModel();
            this.BorderWidthPicker.SelectedItem = null;
            this.BorderLocationPicker.SelectedItem = null;
            this.BorderColorPicker.SelectedItem = null;
            this.BackgroundColorPicker.SelectedItem = null;
        }
    }
}