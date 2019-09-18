using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.PathControl.GettingStartedCategory.GettingStartedExample
{
	public class PathGettingStartedCSharp : ContentView
	{
		public PathGettingStartedCSharp ()
		{
            // >> path-gettingstarted-starpath-code
            var mainGrid = new Grid() { ColumnSpacing = 20, RowSpacing = 10};
            mainGrid.RowDefinitions.Add(new RowDefinition() { Height = 200 });
            mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            
            var starPath = new RadPath()
            {
                Geometry = Geometries.Star,
                StrokeThickness = 0,
                Fill = new RadSolidColorBrush(Color.FromHex("FFC325"))
            };
            mainGrid.Children.Add(starPath);
            // << path-gettingstarted-starpath-code

            // >> path-gettingstarted-custompath-code
            var arcPath = new RadPath()
            {
                StrokeThickness = 4,
                Stroke = new RadSolidColorBrush(Color.FromHex("2EC262"))
            };
            RadPathFigure arc = new RadPathFigure();
            arc.StartPoint = new Point(0.85, 0.85);
            arc.Segments.Add(new RadArcSegment()
            {
                Center = new Point(0.5, 0.5),
                Size = new Size(1, 1),
                StartAngle = 315,
                SweepAngle = 270
            });

            RadPathGeometry geometry = new RadPathGeometry();
            geometry.Figures.Add(arc);
            arcPath.Geometry = geometry;

            mainGrid.Children.Add(arcPath);
            // << path-gettingstarted-custompath-code
            Grid.SetColumn(arcPath, 1);

            Content = mainGrid;			
		}
	}
}