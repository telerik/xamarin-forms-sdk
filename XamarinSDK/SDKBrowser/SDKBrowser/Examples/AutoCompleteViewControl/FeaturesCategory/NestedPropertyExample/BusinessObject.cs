namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.NestedPropertyExample
{
    // >> autocompleteview-features-nestedproperty-businessobject
    public class BusinessObject
    {
        public BusinessObject(string name)
        {
            this.Person = new Person() { Name = name };
        }

        public Person Person { get; set; }
    }
    // << autocompleteview-features-nestedproperty-businessobject
}

