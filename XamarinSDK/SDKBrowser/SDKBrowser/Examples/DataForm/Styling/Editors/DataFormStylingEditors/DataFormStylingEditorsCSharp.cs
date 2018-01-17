using SDKBrowser.Examples.DataForm.Styling.Editors.DataFormStylingEditors;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormStylingEditorsCSharp : ContentPage
    {
        public DataFormStylingEditorsCSharp()
        {
            var dataForm = new RadDataForm();

            dataForm.Source = new Customer();

            // >> dataform-styling-editors
            var positive = "CCFF00";
            var negative = "FF004C";

            var style = new DataFormEditorStyle
            {
                Background = new Background
                {
                    Fill = Color.FromHex("3D6978"),
                    StrokeColor = Color.FromHex(positive),
                    StrokeWidth = 2,
                    StrokeLocation = Location.Bottom
                },
                HeaderFontSize = 17,
                HeaderForeground = Color.White,
                FeedbackFontSize = 13,
                PositiveFeedbackImage = ImageSource.FromFile("success.png"),
                NegativeFeedbackImage = ImageSource.FromFile("fail.png"),
                NegativeFeedbackForeground = Color.FromHex(negative),
                NegativeFeedbackBackground = new Background
                {
                    Fill = Color.FromHex(30 + negative),
                    StrokeColor = Color.FromHex(negative),
                    StrokeWidth = 2,
                    StrokeLocation = Location.All
                },
                Height = 70,
                FeedbackImageSize = new Size(10, 10),

            };

            dataForm.EditorStyle = style;
            dataForm.BackgroundColor = Color.FromHex("345966");
            // << dataform-styling-editors

            this.Content = dataForm;
        }
    }
}
