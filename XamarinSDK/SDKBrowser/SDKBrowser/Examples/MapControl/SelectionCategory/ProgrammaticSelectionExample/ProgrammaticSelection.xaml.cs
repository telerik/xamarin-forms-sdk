using System;
using Telerik.XamarinForms.Map;
using Telerik.XamarinForms.ShapefileReader;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.SelectionCategory.ProgrammaticSelectionExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticSelection : ContentView
    {
        public ProgrammaticSelection()
        {
            InitializeComponent();

            // >> map-selection-settintsource
            var assembly = this.GetType().Assembly;
            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp", assembly);
            var dataSource = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.dbf", assembly);
            this.reader.Source = source;
            this.reader.DataSource = dataSource;
            // << map-selection-settintsource

            this.smPicker.ItemsSource = Enum.GetValues(typeof(Telerik.XamarinForms.Map.SelectionMode));
        }

        private void SelectClicked(object sender, EventArgs e)
        {
            var shape = this.GetItemFromCountryName(this.cntrSelectEntry.Text);
            if (shape != null)
            {
                this.mapShapeLayer.SelectedShapes.Add(shape);
            }

            this.cntrSelectEntry.Text = string.Empty;
        }

        private void DeselectClicked(object sender, EventArgs e)
        {
            var shape = this.GetItemFromCountryName(this.cntrDeselectEntry.Text);
            if (shape != null && this.mapShapeLayer.SelectedShapes.Contains(shape))
            {
                this.mapShapeLayer.SelectedShapes.Remove(shape);
            }

            this.cntrDeselectEntry.Text = string.Empty;
        }

        // >> map-selection-runtime-code
        private void SelectFranceClicked(object sender, EventArgs e)
        {
            var shape = this.GetItemFromCountryName("France");
            if (shape != null)
            {
                this.mapShapeLayer.SelectedShapes.Add(shape);
            }
        }

        private void DeselectFranceClicked(object sender, EventArgs e)
        {
            var shape = this.GetItemFromCountryName("France");
            if (shape != null && this.mapShapeLayer.SelectedShapes.Contains(shape))
            {
                this.mapShapeLayer.SelectedShapes.Remove(shape);
            }
        }

        private IShape GetItemFromCountryName(string countryName)
        {
            foreach (var shape in this.reader.Shapes)
            {
                var name = shape.GetAttribute("CNTRY_NAME").ToString();
                if (name == countryName)
                {
                    return shape;
                }
            }
            return null;
        }
        // << map-selection-runtime-code

        private void DeselectAllClicked(object sender, EventArgs e)
        {
            this.mapShapeLayer.SelectedShapes.Clear();
        }

        private void SelectedModeChanged(object sender, EventArgs e)
        {
            mapShapeLayer.SelectionMode = (Telerik.XamarinForms.Map.SelectionMode)smPicker.SelectedItem;
        }
    }
}
