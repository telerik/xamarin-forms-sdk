using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SDKBrowser.Examples.ListView.Styling.BindablePressedItemStyle;

namespace SDKBrowser.Examples.ListView
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindablePressedItemStyle : ContentPage
    {
        public BindablePressedItemStyle()
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