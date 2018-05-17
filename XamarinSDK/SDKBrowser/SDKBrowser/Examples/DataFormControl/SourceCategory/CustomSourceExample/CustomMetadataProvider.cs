using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.SourceCategory.CustomSourceExample
{
    // >> dataform-source-customsource-metadataprovider
    public class CustomMetadataProvider : PropertyMetadataProviderBase
    {
        private readonly List<IEntityProperty> entityProperties = new List<IEntityProperty>();

        public override List<IEntityProperty> EntityProperties
        {
            get
            {
                return entityProperties;
            }
        }

        public override void Initialize(object source)
        {
            var sourceDictionary = source as Dictionary<string, string>;

            foreach (var item in sourceDictionary)
            {
                var metadata = new EntityPropertyMetadata
                {
                    Header = item.Key
                };

                var property = new CustomEntityProperty(item.Key, sourceDictionary, metadata);

                this.entityProperties.Add(property);
            }
        }
    }
    // << dataform-source-customsource-metadataprovider
}

