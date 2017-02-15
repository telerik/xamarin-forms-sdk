using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace SDKBrowser.iOS
{
    public class CustomNavigationRenderer : NavigationRenderer
    {
        public override void SetViewControllers(UIViewController[] controllers, bool animated)
        {
            base.SetViewControllers(controllers, animated);

            foreach (UIViewController controller in controllers)
            {
                ((UINavigationController)controller).InteractivePopGestureRecognizer.Enabled = false;
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (this.InteractivePopGestureRecognizer != null)
            {
                this.InteractivePopGestureRecognizer.Enabled = false;
            }
        }
    }
}