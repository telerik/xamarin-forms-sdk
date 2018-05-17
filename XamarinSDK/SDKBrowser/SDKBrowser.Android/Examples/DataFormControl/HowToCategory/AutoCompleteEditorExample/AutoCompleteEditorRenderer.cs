using Android.Widget;
using Com.Telerik.Widget.Dataform.Engine;
using Com.Telerik.Widget.Dataform.Visualization;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using Com.Telerik.Widget.Dataform.Visualization.Editors;
using SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample;
using SDKBrowser.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomAutoCompleteDataForm), typeof(AutoCompleteEditorRenderer))]

namespace SDKBrowser.Droid.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample
{
    // >> dataform-howto-autocompleteeditorrenderer-csharp
    public class AutoCompleteEditorRenderer : DataFormRenderer
    {
        private readonly Java.Lang.Object[] items = new Java.Lang.Object[] { "pretty cat", "fat cat", "fluffy cat" };
        protected override EntityPropertyEditor GetCustomEditorForProperty(RadDataForm form, IEntityProperty nativeProperty, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            if (nativeProperty.Name() == "Animal")
            {
                return new Com.Telerik.Widget.Dataform.Visualization.Editors.DataFormAutoCompleteEditor(form, nativeProperty);
            }

            return base.GetCustomEditorForProperty(form, nativeProperty, property);
        }

        protected override void UpdateEditor(EntityPropertyEditor editor, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            base.UpdateEditor(editor, property);

            if (editor.Property().Name() == "Animal")
            {
                var autoComplete = editor.EditorView as AutoCompleteTextView;
                autoComplete.Adapter = new ArrayAdapter(Forms.Context, Resource.Layout.data_form_autocomplete_item, this.items);
            }
        }
    }
    // << dataform-howto-autocompleteeditorrenderer-csharp
}