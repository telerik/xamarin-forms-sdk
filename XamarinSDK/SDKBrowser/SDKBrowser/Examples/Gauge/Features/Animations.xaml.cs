using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Gauge
{
    public partial class Animations : ContentPage
    {
        private bool isShowing;

        public Animations()
        {
            InitializeComponent();
            this.isShowing = true;

            this.listView1.ItemsSource = new List<string>
            {
                "BounceIn",
                "BounceOut",
                "CubicIn",
                "CubicInOut",
                "CubicOut",
                "Linear",
                "SinIn",
                "SinInOut",
                "SinOut",
                "SpringIn",
                "SpringOut",
            };

            Device.StartTimer(TimeSpan.FromMilliseconds(2000), OnTimerTick);
        }

        private void ListViewEasing_SelectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Easing easing = this.GetEasing((string)this.listView1.SelectedItem);
            this.gauge1.AnimationSettings.Easing = easing;
        }

        private Easing GetEasing(string selectedItem)
        {
            if (selectedItem == "BounceIn")
            {
                return Easing.BounceIn;
            }
            else if (selectedItem == "BounceOut")
            {
                return Easing.BounceOut;
            }
            else if (selectedItem == "CubicIn")
            {
                return Easing.CubicIn;
            }
            else if (selectedItem == "CubicInOut")
            {
                return Easing.CubicInOut;
            }
            else if (selectedItem == "CubicOut")
            {
                return Easing.CubicOut;
            }
            else if (selectedItem == "Linear")
            {
                return Easing.Linear;
            }
            else if (selectedItem == "SinIn")
            {
                return Easing.SinIn;
            }
            else if (selectedItem == "SinInOut")
            {
                return Easing.SinInOut;
            }
            else if (selectedItem == "SinOut")
            {
                return Easing.SinOut;
            }
            else if (selectedItem == "SpringIn")
            {
                return Easing.SpringIn;
            }
            else if (selectedItem == "SpringOut")
            {
                return Easing.SpringOut;
            }
            else
            {
                return Easing.CubicOut;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.isShowing = false;
        }

        private bool OnTimerTick()
        {
            if (this.isShowing)
            {
                Random r = new Random();
                ((GaugeShapeIndicator)this.gauge1.Indicators[0]).Value = r.Next(0, 200);
                ((GaugeBarIndicator)this.gauge1.Indicators[1]).Value = r.Next(0, 200);
                ((GaugeNeedleIndicator)this.gauge1.Indicators[2]).Value = r.Next(0, 200);
            }

            return this.isShowing;
        }

        private void SliderDuration_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.gauge1.AnimationSettings.Duration = (int)e.NewValue;
        }
    }
}
