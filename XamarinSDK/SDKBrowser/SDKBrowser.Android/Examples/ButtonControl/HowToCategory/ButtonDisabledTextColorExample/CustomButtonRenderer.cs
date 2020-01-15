using System.ComponentModel;
using SDKBrowser.Droid.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using SDKBrowser.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using Xamarin.Forms.Platform.Android;

// >> button-disabled-text-color-androidrenderer-cs
[assembly: Xamarin.Forms.ExportRenderer(typeof(MyRadButton), typeof(CustomButtonRenderer))]
namespace SDKBrowser.Droid.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample
{
    public class CustomButtonRenderer : Telerik.XamarinForms.InputRenderer.Android.ButtonRenderer
    {
        public CustomButtonRenderer(Android.Content.Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            this.ModifyTextColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == Xamarin.Forms.Button.IsEnabledProperty.PropertyName)
            {
                this.ModifyTextColor();
            }
        }

        private void ModifyTextColor()
        {
            if (this.Element.IsEnabled == true)
            {
                this.Control.SetTextColor(Android.Graphics.Color.Red);
            }
            else
            {
                this.Control.SetTextColor(Android.Graphics.Color.Gray);
            }
        }
    }
}
// << button-disabled-text-color-androidrenderer-cs