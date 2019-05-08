using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample
{
    // >> dataform-howto-autocompleteeditor-source
    public class SourceItem : NotifyPropertyChangedBase
    {
        private string city;

        [DisplayOptions(Header = "City")]
        public string City
        {
            get { return this.city; }
            set
            {
                if (this.city != value)
                {
                    this.city = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
    // << dataform-howto-autocompleteeditor-source
}
