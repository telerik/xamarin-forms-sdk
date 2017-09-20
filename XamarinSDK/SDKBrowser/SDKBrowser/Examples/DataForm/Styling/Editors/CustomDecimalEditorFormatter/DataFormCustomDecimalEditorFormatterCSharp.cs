using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm.Styling.Editors.CustomDecimalEditorFormatter
{
	public class DataFormCustomDecimalEditorFormatterCSharp : ContentPage
	{
		public DataFormCustomDecimalEditorFormatterCSharp()
		{
			var dataForm = new CustomRadDataForm
			{
				Source = new SourceItem()
			};

			Content = dataForm;
		}
	}
}
