using Telerik.XamarinForms.Input.AutoComplete;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.CustomFilteringExample
{
    // >> autocompleteview-filtering-class
    public class CustomAutoCompleteViewFilter : IAutoCompleteFilter
    {
        public bool Filter(object item, string searchText, CompletionMode completionMode)
        {
            Person person = (Person)item;
            string lowerFirstName = person.FirstName.ToLower();
            string lowerLastName = person.LastName.ToLower();
            string lowerSearchText = searchText.ToLower();
            return lowerFirstName.Contains(lowerSearchText) || lowerLastName.Contains(lowerSearchText);
        }
    }
    // << autocompleteview-filtering-class
}
