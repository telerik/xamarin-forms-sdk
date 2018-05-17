using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.DataFormControl.EditorsCategory.CustomEditorExample
{
    public class SourceItem : NotifyPropertyChangedBase
    {
        private Options option;

        public Options Option
        {
            get
            {
                return this.option;
            }
            set
            {
                if (value != this.option)
                {
                    this.option = value;
                    OnPropertyChanged();
                }
                
            }
        }
    }
}
