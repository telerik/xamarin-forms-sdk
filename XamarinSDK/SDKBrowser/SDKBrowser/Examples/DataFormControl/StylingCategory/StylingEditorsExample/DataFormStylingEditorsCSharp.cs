using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.StylingCategory.StylingEditorsExample
{
    public class DataFormStylingEditorsCSharp : ContentView
    {
        public DataFormStylingEditorsCSharp()
        {
            var dataForm = new RadDataForm();

            dataForm.Source = new Customer();

            // >> dataform-styling-editors
            var negative = "F8082D";

            var style = new DataFormEditorStyle
            {
                Background = new Background
                {
                    Fill = Color.FromHex("EBF4FF"),
                    StrokeColor = Color.FromHex("B2DFF4"),
                    StrokeWidth = 2,
                    StrokeLocation = Location.Bottom
                },
                HeaderFontSize = 17,
                HeaderForeground = Color.FromHex("505050"),
                FeedbackFontSize = 13,
                PositiveFeedbackImage = ImageSource.FromFile("success.png"),
                NegativeFeedbackImage = ImageSource.FromFile("fail.png"),
                NegativeFeedbackForeground = Color.FromHex(negative),
                NegativeFeedbackBackground = new Background
                {                  
                    StrokeColor = Color.FromHex(negative),
                    StrokeWidth = 2,
                    StrokeLocation = Location.All
                },
                Height = 70,
                FeedbackImageSize = new Size(10, 10),

            };

            dataForm.EditorStyle = style;
            dataForm.BackgroundColor = Color.FromHex("B7D8FF");
            // << dataform-styling-editors

            this.Content = dataForm;
        }
    }
}
