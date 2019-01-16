using Android.Content;
using Com.Telerik.Widget.Autocomplete;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample;
using SDKBrowser.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomRadAutoCompleteDataForm), typeof(RadAutoCompleteEditorRenderer))]
namespace SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample
{
    public class RadAutoCompleteEditorRenderer : DataFormRenderer
    {
        public RadAutoCompleteEditorRenderer(Context context) : base(context)
        {
        }
        protected override void UpdateEditor(EntityPropertyEditor editor, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            base.UpdateEditor(editor, property);

            if (editor.Property().Name() == "Towns")
            {
                var autoComplete = editor.EditorView as RadAutoCompleteTextView;
                if (autoComplete != null)
                {
                    autoComplete.DisplayMode = DisplayMode.Tokens;
                }
            }
        }
    }
}
