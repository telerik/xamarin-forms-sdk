using System.ComponentModel;
using SDKBrowser.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using SDKBrowser.UWP.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

// >> button-disabled-text-color-uwprenderer-cs
[assembly: ExportRenderer(typeof(MyRadButton), typeof(CustomButtonRenderer))]
namespace SDKBrowser.UWP.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample
{
    public class CustomButtonRenderer : Telerik.XamarinForms.InputRenderer.UWP.ButtonRenderer
    {
        public CustomButtonRenderer() : base()
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
                ModifyTextColor();
            }
        }

        private void ModifyTextColor()
        {
            if (this.Element.IsEnabled == true)
            {
                this.Control.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
            }
            else
            {
                this.Control.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 165, 0, 0));
            }
        }

    }
}
// << button-disabled-text-color-uwprenderer-cs
