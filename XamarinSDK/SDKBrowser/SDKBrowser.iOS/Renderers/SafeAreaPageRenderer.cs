using SDKBrowser.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(SafeAreaPageRenderer))]

namespace SDKBrowser.iOS.Renderers
{
    public class SafeAreaPageRenderer : PageRenderer
    {
        public override void ViewSafeAreaInsetsDidChange()
        {
            base.ViewSafeAreaInsetsDidChange();
            this.UpdatePageSafeArea();
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs eventArgs)
        {
            base.OnElementChanged(eventArgs);
            this.UpdatePageSafeArea();
        }

        private void UpdatePageSafeArea()
        {
            var page = this.Element as Page;

            if (page != null)
            {
                if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
                {
                    var insets = NativeView.SafeAreaInsets;

                    page.Padding = new Thickness(insets.Left, insets.Top, insets.Right, insets.Bottom);
                }
                else
                {
                    page.Padding = new Thickness(0, 20, 0, 0);
                }
            }
        }
    }
}
