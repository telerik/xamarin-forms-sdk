using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.LayoutsCategory.StackLayoutExample
{
    // >> dataform-grouplayouts-stacklayout-sourceitem
    public class SourceItem
    {
        [DisplayOptions(Group = "Value", Header = "1:", Position = 2)]
        public int Value { get; set; } = 2;

        [DisplayOptions(Group = "Value", Header = "2:", Position = 1)]
        public int Value1 { get; set; } = 1;

        [DisplayOptions(Group = "Value", Header = "3:", Position = 0)]
        public int Value2 { get; set; } = 0;

        [DisplayOptions(Group = "Name", Header = "Name 1: ", Position = 0)]
        public string Name { get; set; } = "position 0";

        [DisplayOptions(Group = "Name", Header = "Name 2:", Position = 1)]
        public string Name1 { get; set; } = "position 1";
    }
    // << dataform-grouplayouts-stacklayout-sourceitem
}
