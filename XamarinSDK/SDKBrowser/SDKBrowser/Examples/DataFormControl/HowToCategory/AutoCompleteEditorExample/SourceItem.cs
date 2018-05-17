using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample
{
    public class SourceItem : NotifyPropertyChangedBase
    {
        private string animal;

        [DisplayOptions(Header = "Animal")]
        public string Animal
        {
            get { return this.animal; }
            set
            {
                if (this.animal != value)
                {
                    this.animal = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
