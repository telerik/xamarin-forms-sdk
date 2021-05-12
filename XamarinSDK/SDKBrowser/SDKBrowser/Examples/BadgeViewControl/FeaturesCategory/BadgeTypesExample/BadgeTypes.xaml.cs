using System;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BadgeViewControl.FeaturesCategory.BadgeTypesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BadgeTypes : ContentView
    {
        public BadgeTypes()
        {
            InitializeComponent();
            // >> badgeview-badge-types-code-behind
            this.selectBadgeType.ItemsSource = Enum.GetValues(typeof(BadgeType));
            this.selectBadgeType.SelectedIndex = 0;
            this.badge.SetBinding(RadBadgeView.BadgeTypeProperty, new Binding(nameof(this.selectBadgeType.SelectedItem), source: this.selectBadgeType));
            // << badgeview-badge-types-code-behind
        }
    }
}