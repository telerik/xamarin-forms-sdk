using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.BindablePressedItemStyleExample
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindablePressedItemStyle : ContentView
    {
        public BindablePressedItemStyle()
        {
            this.InitializeComponent();
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