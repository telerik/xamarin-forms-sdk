using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DateTimePickerControl.FeaturesCategory.LocalizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Localization : ContentView
    {
        public Localization()
        {
            // >> datetimepicker-localization-code-behind
            TelerikLocalizationManager.Manager = new CustomDateTimePickerLocalizationManager();
            // << datetimepicker-localization-code-behind
            InitializeComponent();
        }
    }
}