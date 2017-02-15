using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataForm.GroupLayouts.LayoutSelector
{
    // >> dataform-grouplayouts-layoutselector-selector
    public class CustomGroupLayoutDefinitionSelector : IDataFormGroupLayoutDefinitionSelector
    {
        public DataFormGroupLayoutDefinition SelectLayoutDefinition(string groupName)
        {
            if (groupName == "Name")
            {
                return new DataFormGroupGridLayoutDefinition();
            }

            if (groupName == "Value")
            {
                return new DataFormGroupStackLayoutDefinition { Orientation = Orientation.Vertical };
            }

            return null;
        }
    }
    // << dataform-grouplayouts-layoutselector-selector

}


