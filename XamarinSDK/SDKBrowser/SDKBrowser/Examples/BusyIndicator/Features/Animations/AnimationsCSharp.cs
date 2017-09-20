using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Primitives;
using Telerik.XamarinForms.Common;
using System;

namespace SDKBrowser.Examples.BusyIndicator
{
    public class AnimationsCSharp : ContentPage
    {
        public AnimationsCSharp()
        {
            // >> busyindicator-animations-csharp
            RadBusyIndicator radBusyIndicator = new RadBusyIndicator()
            {
                IsBusy = true,
                AnimationType = AnimationType.Custom,
                Content = new Label() { Text = "This is the content of the RadBusyIndicator control displayed when the indicator is not busy." },
                BusyContent = new Label()
                {
                    Text = "Loading...",
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, false),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, false),
                },
            };

            RadDoubleAnimation annimation = new RadDoubleAnimation() { Duration = 800, From = 0.1, To = 1, PropertyPath = "Opacity", Target = radBusyIndicator.BusyContent, RepeatForever = true, AutoReverse = true };
            radBusyIndicator.Animations.Add(annimation);

            Device.StartTimer(TimeSpan.FromMilliseconds(5000),
                () =>
                {
                    radBusyIndicator.IsBusy = false;
                    return false;
                });
            // << busyindicator-animations-csharp
                        
            Content = radBusyIndicator;
        }
    }
}

