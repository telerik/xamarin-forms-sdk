using System;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DisplayValueFormatExample
{
    // >> dataform-dataannotations-displayvalueformat-source
    public class VoteResults
    {
        [DisplayOptions(Header = "Votes")]
        [DisplayValueFormat(Plural = "{0} votes", Single = "{0} vote", Zero = "no votes")]
        public double Votes { get; set; }

        [DisplayOptions(Header = "Date")]
        [DisplayValueFormat(Date = "yyyy-MM-dd")]
        public DateTime Date { get; set; } = new DateTime(2016, 10, 27);
    }
    // << dataform-dataannotations-displayvalueformat-source
}
