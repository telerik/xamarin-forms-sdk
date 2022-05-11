using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.EntryControl.FeaturesCategory.TextBindingExample
{
    // >> entry-textbinding-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private string myEntryText;

        public string MyEntryText
        {
            get { return this.myEntryText; }
            set { this.UpdateValue(ref this.myEntryText, value); }
        }
    }
    // << entry-textbinding-viewmodel
}
