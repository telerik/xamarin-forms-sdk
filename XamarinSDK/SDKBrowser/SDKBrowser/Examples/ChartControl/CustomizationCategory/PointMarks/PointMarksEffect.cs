using SDKBrowser.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    public class PointMarksEffect : RoutingEffect
    {
        public const string PointMarksEffectName = "PointMarksEffect";
        public const string EffectId = Constants.TelerikName + "." + PointMarksEffectName;

        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached("Color", typeof(Color), typeof(PointMarksEffect), Color.Default);

        public PointMarksEffect()
            : base(EffectId)
        {
        }

        public static Color GetColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(ColorProperty);
        }

        public static void SetColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(ColorProperty, value);
        }
    }
}
