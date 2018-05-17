using SDKBrowser.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using SDKBrowser.iOS.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using UIKit;
using Xamarin.Forms.Platform.iOS;

// >> button-disabled-text-color-iosrenderer-cs
[assembly: Xamarin.Forms.ExportRenderer(typeof(MyRadButton), typeof(CustomButtonRenderer))]
namespace SDKBrowser.iOS.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample
{
    public class CustomButtonRenderer : Telerik.XamarinForms.InputRenderer.iOS.ButtonRenderer
    {
        public CustomButtonRenderer() : base()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTitleColor(UIColor.Gray, UIControlState.Disabled);
                Control.SetTitleColor(UIColor.Red, UIControlState.Normal);
            }
        }
    }
}
// << button-disabled-text-color-iosrenderer-cs