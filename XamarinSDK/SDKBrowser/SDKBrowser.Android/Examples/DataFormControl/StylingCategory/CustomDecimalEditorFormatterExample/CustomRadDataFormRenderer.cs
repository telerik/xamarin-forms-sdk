using System;
using Android.Runtime;
using Com.Telerik.Android.Common;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using Com.Telerik.Widget.Dataform.Visualization.Editors;
using SDKBrowser.Droid.Examples.DataFormControl.StylingCategory.CustomDecimalEditorFormatterExample;
using SDKBrowser.Examples.DataFormControl.StylingCategory.CustomDecimalEditorFormatterExample;
using Telerik.XamarinForms.Input.DataForm;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomRadDataForm), typeof(CustomRadDataFormRenderer))]
namespace SDKBrowser.Droid.Examples.DataFormControl.StylingCategory.CustomDecimalEditorFormatterExample
{
    public class CustomRadDataFormRenderer : DataFormRenderer
	{
        public CustomRadDataFormRenderer(Android.Content.Context context)
            : base(context)
        {
        }

        protected override void UpdateEditor(EntityPropertyEditor editor, IEntityProperty property)
		{
			base.UpdateEditor(editor, property);

			Type editorType = editor.GetType();
			if (typeof(DataFormDecimalEditor).IsAssignableFrom(editorType))
			{
				var dfEditor = editor.JavaCast<DataFormIntegerEditor>();
				dfEditor.ValueFormatter = new CustomValueFormatter();
			}
		}

		private class CustomValueFormatter : Java.Lang.Object, IFunction
		{
			public Java.Lang.Object Apply(Java.Lang.Object editorValue)
			{
				return string.Format("$ {0:n}", (double)editorValue);
			}
		}
	}
}
