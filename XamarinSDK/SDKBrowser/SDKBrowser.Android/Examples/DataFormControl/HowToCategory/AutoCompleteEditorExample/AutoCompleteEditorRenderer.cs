using Android.Content;
using Android.Widget;
using NativeViz = Com.Telerik.Widget.Dataform.Visualization;
using NativeEngine = Com.Telerik.Widget.Dataform.Engine;
using NativeCore = Com.Telerik.Widget.Dataform.Visualization.Core;
using NativeEditors = Com.Telerik.Widget.Dataform.Visualization.Editors;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;
using SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample;
using SDKBrowser.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample;

[assembly: ExportRenderer(typeof(CustomAutoCompleteDataForm), typeof(AutoCompleteEditorRenderer))]
namespace SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample
{
    // >> dataform-howto-autocompleteeditorrenderer-csharp
    public class AutoCompleteEditorRenderer : DataFormRenderer
    {
        private readonly Java.Lang.Object[] items = new Java.Lang.Object[] { "Madrid", "Paris", "Barcelona", "New York", "Budapest", "Melbourne", "Bangkok" };

        public AutoCompleteEditorRenderer(Context context): base(context)
        {

        }
        protected override NativeCore.EntityPropertyEditor GetCustomEditorForProperty(NativeViz.RadDataForm form, NativeEngine.IEntityProperty nativeProperty, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            if (nativeProperty.Name() == "City")
            {
                return new NativeEditors.DataFormAutoCompleteEditor(form, nativeProperty);
            }

            return base.GetCustomEditorForProperty(form, nativeProperty, property);
        }

        protected override void UpdateEditor(NativeCore.EntityPropertyEditor editor, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            base.UpdateEditor(editor, property);

            if (editor.Property().Name() == "City")
            {
                var autoComplete = editor.EditorView as AutoCompleteTextView;
                autoComplete.Adapter = new ArrayAdapter(this.Context, Resource.Layout.data_form_autocomplete_item, this.items);
            }
        }
    }
    // << dataform-howto-autocompleteeditorrenderer-csharp
}