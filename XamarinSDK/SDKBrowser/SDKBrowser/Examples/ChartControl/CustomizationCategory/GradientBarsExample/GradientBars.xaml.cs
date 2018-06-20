using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradientBars : ContentView
    {
        public GradientBars()
        {
            this.InitializeComponent();

            this.BindingContext = new List<ChartItem>
            {
                new ChartItem { Category = "GOGO", Value1 = 900, Value2 = 600, },
                new ChartItem { Category = "dyNACO", Value1 = 800, Value2 = 500, },
                new ChartItem { Category = "Tec-on", Value1 = 670, Value2 = 250, },
                new ChartItem { Category = "BOYUU", Value1 = 440, Value2 = 150, },
                new ChartItem { Category = "xDuoo", Value1 = 340, Value2 = 140, },
                new ChartItem { Category = "Nobsound", Value1 = 340, Value2 = 110, },
            };
        }
    }
}