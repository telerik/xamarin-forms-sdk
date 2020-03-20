using System;
using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.InteractionModeExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InteractionMode : ContentView
    {
        public InteractionMode()
        {
            InitializeComponent();

            // >> map-interactionmode-settintsource
            var assembly = this.GetType().Assembly;
            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp", assembly);
            this.reader.Source = source;
            // << map-interactionmode-settintsource

            this.interactionModePicker.ItemsSource = Enum.GetValues(typeof(Telerik.XamarinForms.Map.InteractionMode));
        }

        private void InteractionModeChanged(object sender, EventArgs e)
        {
            this.map.InteractionMode = (Telerik.XamarinForms.Map.InteractionMode)this.interactionModePicker.SelectedItem;
        }
    }
}