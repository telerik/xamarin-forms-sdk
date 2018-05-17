using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.SourceCategory.CustomSourceExample
{
    // >> dataform-source-customsource-entityproperty
    public class CustomEntityProperty : IEntityProperty
    {
        private readonly Dictionary<string, string> dataItem;

        private readonly string propertyName;
        private readonly EntityPropertyMetadata metadata;

        public CustomEntityProperty(string propertyName, Dictionary<string, string> item, EntityPropertyMetadata metadata)
        {
            this.metadata = metadata;
            this.propertyName = propertyName;
            this.dataItem = item;
        }

        public object OriginalValue
        {
            get
            {
                return this.dataItem[propertyName];
            }
        }

        public EntityPropertyMetadata Metadata
        {
            get
            {
                return this.metadata;
            }
        }

        public object DataItem
        {
            get
            {
                return this.dataItem;
            }
        }

        public string PropertyName
        {
            get
            {
                return this.propertyName;
            }
        }

        public object PropertyValue { get; set; }

        public Type PropertyType
        {
            get
            {
                return typeof(string);
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Commit()
        {
            this.dataItem[propertyName] = (string)this.PropertyValue;
        }
    }
    // << dataform-source-customsource-entityproperty
}

