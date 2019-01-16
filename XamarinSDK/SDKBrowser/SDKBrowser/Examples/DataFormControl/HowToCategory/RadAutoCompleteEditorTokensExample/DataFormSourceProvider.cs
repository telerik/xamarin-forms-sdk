using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample
{
    public class DataFormSourceProvider : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.ToString().Equals("Towns"))
            {
                return new List<string> { "Tokyo", "London", "Paris", "New York City" , "Brussels", "Moskow", "Berlin", "Sofia", "Boston"};
            }
            return null;
        }
    }
}
