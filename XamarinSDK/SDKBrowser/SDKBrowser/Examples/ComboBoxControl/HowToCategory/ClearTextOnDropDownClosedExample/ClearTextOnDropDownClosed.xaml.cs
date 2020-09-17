using Xamarin.Forms;

namespace SDKBrowser.Examples.ComboBoxControl.HowToCategory.ClearTextOnDropDownClosedExample
{
    public partial class ClearTextOnDropDownClosed : ContentView
    {
        public ClearTextOnDropDownClosed()
        {
            InitializeComponent();
        }
        // >> combobox-cleartext-dropdown-closed-unfocused
        private void comboBox_Unfocused(object sender, FocusEventArgs e)
        {
            this.comboBox.Text = string.Empty;
        }
        // << combobox-cleartext-dropdown-closed-unfocused
    }
}