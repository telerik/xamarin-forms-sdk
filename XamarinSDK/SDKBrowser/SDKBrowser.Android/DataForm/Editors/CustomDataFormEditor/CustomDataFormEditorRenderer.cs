using Android.App;
using Com.Telerik.Widget.Dataform.Engine;
using Com.Telerik.Widget.Dataform.Visualization;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using SDKBrowser.Droid.DataForm.Editors.CustomDataFormEditor;
using SDKBrowser.Examples.DataForm.Editors.CustomEditor;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEditorDataForm), typeof(CustomDataFormEditorRenderer))]

namespace SDKBrowser.Droid.DataForm.Editors.CustomDataFormEditor
{
    public class CustomDataFormEditorRenderer : DataFormRenderer
    {
        protected override EntityPropertyEditor GetCustomEditorForProperty(RadDataForm form, IEntityProperty nativeProperty, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            if (property.PropertyName == "Option")
            {
                return new PopupEditor(form, nativeProperty, ((Activity) this.Context).FragmentManager);
            }

            return base.GetCustomEditorForProperty(form, nativeProperty, property);
        }
    }
}