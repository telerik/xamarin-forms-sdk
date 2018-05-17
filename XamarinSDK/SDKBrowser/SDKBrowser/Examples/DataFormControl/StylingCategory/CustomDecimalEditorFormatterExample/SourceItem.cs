using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.StylingCategory.CustomDecimalEditorFormatterExample
{
	public class SourceItem
	{
		private double price = 15.64;

		[DisplayOptions(Header = "Price", PlaceholderText = "price")]
		public double Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}
