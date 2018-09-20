namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.CustomFilteringExample
{
    // >> autocompleteview-filtering-businessobject
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
    // << autocompleteview-filtering-businessobject
}
