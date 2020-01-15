using Android.App;
using Com.Telerik.Widget.Dataform.Engine;
using Com.Telerik.Widget.Dataform.Visualization;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using SDKBrowser.Droid.Examples.DataFormControl.EditorsCategory.CustomEditorExample;
using SDKBrowser.Examples.DataFormControl.EditorsCategory.CustomEditorExample;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEditorDataForm), typeof(CustomDataFormEditorRenderer))]

namespace SDKBrowser.Droid.Examples.DataFormControl.EditorsCategory.CustomEditorExample
{
    public class CustomDataFormEditorRenderer : DataFormRenderer
    {
        public CustomDataFormEditorRenderer(Android.Content.Context context)
            : base(context)
        {
        }

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