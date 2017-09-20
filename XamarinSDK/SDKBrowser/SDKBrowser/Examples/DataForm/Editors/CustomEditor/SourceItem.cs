using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.DataForm.Editors.CustomEditor
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
