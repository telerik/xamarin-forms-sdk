using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PathControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PathGettingStartedXaml : ContentView
    {
        public PathGettingStartedXaml()
        {
            this.InitializeComponent();

            // >> path-gettingstarted-built-in-geometry
            this.path.Geometry = Geometries.Star;
            // << path-gettingstarted-built-in-geometry

            // >> path-gettingstarted-assigning-custom-geometry
            this.customPath.Geometry = this.CreateArc();
            // << path-gettingstarted-assigning-custom-geometry

            this.customLine.Geometry = this.CreateLineGeometry();
        }

        // >> path-geometry-set-line-geometry
        internal RadPathGeometry CreateLineGeometry()
        {
            // >> path-geometry-line-segment
            RadPathFigure line = new RadPathFigure();
            line.StartPoint = new Point(0.8, 0.1);
            line.Segments.Add(new RadLineSegment(new Point(0.1, 0.8)));
            // << path-geometry-line-segment
            line.Segments.Add(new RadArcSegment() { Center = new Point(0.125, 0.825), StartAngle = 135, SweepAngle = 180, Size = new Size(0.070710678, 0.070710678) });
            line.Segments.Add(new RadLineSegment(new Point(0.85, 0.15)));
            line.Segments.Add(new RadArcSegment() { Center = new Point(0.825, 0.125), StartAngle = 315, SweepAngle = 180, Size = new Size(0.070710678, 0.070710678) });

            RadPathGeometry geometry = new RadPathGeometry();
            geometry.Figures.Add(line);

            return geometry;
        }
        // << path-geometry-set-line-geometry

        // >> path-gettingstarted-custom-geometry
        internal RadPathGeometry CreateArc()
        {
            var geometry = new RadPathGeometry();

            RadPathFigure figure = new RadPathFigure();
            figure.StartPoint = new Point(0.5, 0.5);
            // >> path-geometry-arc-segment
            RadArcSegment segmentA = new RadArcSegment();
            segmentA.Center = new Point(0.5, 0.5);
            segmentA.Size = new Size(1, 1);
            segmentA.StartAngle = 315;
            segmentA.SweepAngle = 270;
            // << path-geometry-arc-segment
            figure.Segments.Add(segmentA);

            RadArcSegment segmentB = new RadArcSegment();
            segmentB.Center = new Point(0.5, 0.5);
            segmentB.Size = new Size(1 - 0.1, 1 - 0.1);
            segmentB.StartAngle = 315 + 270;
            segmentB.SweepAngle = -270;
            figure.Segments.Add(segmentB);

            geometry.Figures.Add(figure);

            return geometry;
        }
        // << path-gettingstarted-custom-geometry
    }
}