using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabViewControl.FeaturesCategory.HeaderExample
{
    public partial class TabViewHeader : ContentView
    {
        public TabViewHeader()
        {
            this.InitializeComponent();

            // >> tabview-features-tabviewheader-csharp
            RadTabView tabView = new RadTabView()
            {
                HeaderPosition = TabViewHeaderPosition.Bottom,
                Header = new Telerik.XamarinForms.Primitives.TabViewHeader()
                {
                    BackgroundColor = (Color)(new ColorTypeConverter()).ConvertFromInvariantString("#293955"),
                    OverflowButtonTemplate = new DataTemplate(() =>
                    {
                        return new Label()
                        {
                            Text = " + ",
                            BackgroundColor = (Color)(new ColorTypeConverter()).ConvertFromInvariantString("#CA5100"),
                            Margin = new Thickness(3, 0, 3, 0)
                        };
                    }),
                }
            };

            for (int i = 1; i <= 13; i++)
            {
                tabView.Items.Add(new Telerik.XamarinForms.Primitives.TabViewItem() { HeaderText = string.Format("Tab{0} ", i) });
            }
            // << tabview-features-tabviewheader-csharp
        }
    }
}
