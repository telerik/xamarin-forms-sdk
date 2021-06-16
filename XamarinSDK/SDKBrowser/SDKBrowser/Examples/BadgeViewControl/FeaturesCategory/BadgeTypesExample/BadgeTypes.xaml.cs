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
            this.listView.ItemsSource = Enum.GetValues(typeof(BadgeType));
            // << badgeview-badge-types-code-behind
        }
    }
}