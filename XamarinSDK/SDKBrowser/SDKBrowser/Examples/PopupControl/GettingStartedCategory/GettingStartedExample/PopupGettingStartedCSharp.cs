using System;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.PopupControl.GettingStartedCategory.GettingStartedExample
{
	public class PopupGettingStartedCSharp : ContentView
	{
        RadPopup popup;
        public PopupGettingStartedCSharp()
        {
            // >> popup-getting-started-csharp
            var showPopupBtn = new Button { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Start, Text = "Click here to rate" };
            showPopupBtn.Clicked += ShowPopup;

            popup = new RadPopup { IsModal = true, OutsideBackgroundColor = Color.FromHex("#6F000000") };
            popup.PlacementTarget = showPopupBtn;

            var containerGrid = new Grid { Padding = 20 };
            containerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30) });
            containerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20) });
            containerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            containerGrid.Children.Add(new Label { Text = "Please rate your experience" });

            var rating = new RadShapeRating();
            rating.SetValue(Grid.RowProperty, 1);
            containerGrid.Children.Add(rating);

            var hidePopupBtn = new Button { Padding = new Thickness(2), HorizontalOptions = LayoutOptions.End, Text = "Send" };
            hidePopupBtn.SetValue(Grid.RowProperty, 2);
            hidePopupBtn.Clicked += ClosePopup;
            containerGrid.Children.Add(hidePopupBtn);

            var border = new RadBorder { CornerRadius = new Thickness(8), BackgroundColor = Color.Wheat };
            border.Content = containerGrid;
            popup.Content = border;
            // << popup-getting-started-csharp

            this.Content = showPopupBtn;
        }

        private void ClosePopup(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }
        private void ShowPopup(object sender, EventArgs e)
        {
            popup.IsOpen = true;
        }
    }
}