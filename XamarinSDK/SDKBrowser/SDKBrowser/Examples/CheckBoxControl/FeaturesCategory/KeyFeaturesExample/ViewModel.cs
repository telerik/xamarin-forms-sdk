using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.CheckBoxControl.FeaturesCategory.KeyFeaturesExample
{
    // >> checkbox-key-features-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {
        private bool? isChecked;

        public bool? IsChecked
        {
            get { return this.isChecked; }
            set
            {
                if (this.isChecked != value)
                {
                    this.isChecked = value;
                    OnPropertyChanged();
                }
            }
        }
    }
    // << checkbox-key-features-viewmodel
}