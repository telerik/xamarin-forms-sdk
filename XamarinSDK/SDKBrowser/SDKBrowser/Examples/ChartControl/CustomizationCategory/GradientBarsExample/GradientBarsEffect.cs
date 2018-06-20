using SDKBrowser.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    public class GradientBarsEffect : RoutingEffect
    {
        public const string GradientBarsEffectName = "GradientBarsEffect";
        public const string EffectId = Constants.TelerikName + "." + GradientBarsEffectName;

        public static readonly BindableProperty StartColorProperty =
            BindableProperty.CreateAttached("StartColor", typeof(Color), typeof(GradientBarsEffect), Color.Default);

        public static readonly BindableProperty EndColorProperty =
            BindableProperty.CreateAttached("EndColor", typeof(Color), typeof(GradientBarsEffect), Color.Default);

        public static Color GetStartColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(StartColorProperty);
        }

        public static void SetStartColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(StartColorProperty, value);
        }

        public static Color GetEndColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(EndColorProperty);
        }

        public static void SetEndColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(EndColorProperty, value);
        }

        public GradientBarsEffect()
            : base(EffectId)
        {
        }
    }
}
