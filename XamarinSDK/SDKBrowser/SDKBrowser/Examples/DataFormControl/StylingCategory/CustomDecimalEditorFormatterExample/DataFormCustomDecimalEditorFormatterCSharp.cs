using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.StylingCategory.CustomDecimalEditorFormatterExample
{
    public class DataFormCustomDecimalEditorFormatterCSharp : ContentView
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
