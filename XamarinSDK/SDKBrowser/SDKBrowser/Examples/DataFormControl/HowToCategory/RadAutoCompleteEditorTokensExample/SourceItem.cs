using System.Collections.Generic;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample
{
    public class SourceItem
    {
        [DisplayOptions(Header = "Name")]
        public string Name { get; set; }

        [DisplayOptions(Header = "Towns")]
        public List<string> Towns { get; set; }
    }
}
