using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.DataAnnotations.NativeConversionContext
{
    // >> dataform-dataannotations-native-conversion-context-source
    public class SourceItem : NotifyPropertyChangedBase
    {
        private DateTime utc = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // >> (hide)
        private DateTime unspecified = new DateTime(2010, 1, 1);
        private DateTime local = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Local);

        [DisplayOptions(Header = "Utc", Position = 0)]
        // << (hide)
        [NativeConversionContext(DateTimeKind.Utc)]
        public DateTime Utc
        {
            get
            {
                return this.utc;
            }
            set
            {
                if (this.utc != value)
                {
                    this.utc = value;
                    this.OnPropertyChanged();
                }
            }
        }
        // >> (hide)

        [DisplayOptions(Header = "Unspecified", Position = 1)]
        public DateTime Unspecified
        {
            get
            {
                return this.unspecified;
            }
            set
            {
                if (this.unspecified != value)
                {
                    this.unspecified = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Header = "Local", Position = 2)]
        public DateTime Local
        {
            get
            {
                return this.local;
            }
            set
            {
                if (this.local != value)
                {
                    this.local = value;
                    this.OnPropertyChanged();
                }
            }
        }
        // << (hide)
    }
    // << dataform-dataannotations-native-conversion-context-source
}

