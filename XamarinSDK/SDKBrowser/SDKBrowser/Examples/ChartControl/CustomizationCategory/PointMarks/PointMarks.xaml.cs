using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PointMarks : ContentView
    {
        public PointMarks()
        {
            this.InitializeComponent();

            this.BindingContext = new List<LineChartItem>
            {
                new LineChartItem { XCat = "Mon", YVal = 900, },
                new LineChartItem { XCat = "Tue", YVal = 800, },
                new LineChartItem { XCat = "Wed", YVal = 670, },
                new LineChartItem { XCat = "Thu", YVal = 440, },
                new LineChartItem { XCat = "Fri", YVal = 340, },
            };
        }
    }
}