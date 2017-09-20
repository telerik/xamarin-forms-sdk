using System;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BusyIndicator
{
    public partial class AnimationsXaml : ContentPage
    {
        public AnimationsXaml()
        {
            InitializeComponent();

            // >> busyindicator-animations-code
            RadDoubleAnimation annimation = new RadDoubleAnimation() { Duration = 800, From = 0.1, To = 1, PropertyPath = "Opacity", Target = radBusyIndicator.BusyContent, RepeatForever = true, AutoReverse = true };
            radBusyIndicator.Animations.Add(annimation);

            Device.StartTimer(TimeSpan.FromMilliseconds(5000), 
                () => 
                {
                    radBusyIndicator.IsBusy = false;
                    return false;
                });
            // << busyindicator-animations-code
        }
    }
}
