using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.EditorsCategory.EditorsExample
{
    public class UserPropertyDataSourceProvider : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.Equals("Genre"))
            {
                return new List<string>
                {
                    "Comedy",
                    "Drama",
                    "Non Fiction",
                    "Realistic Fiction",
                    "Romance",
                    "Satire",
                    "Tragedy",
                    "Tragicomedy"
                };
            }

            return null;
        }
    }
}