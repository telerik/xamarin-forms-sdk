using System;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using Com.Telerik.Widget.Dataform.Visualization.Editors;
using Telerik.XamarinForms.Input.DataForm;
using Telerik.XamarinForms.InputRenderer.Android;
using Android.Runtime;
using Com.Telerik.Android.Common;
using Java.Lang;
using Xamarin.Forms;
using SDKBrowser.Examples.DataForm.Styling.Editors.CustomDecimalEditorFormatter;
using SDKBrowser.Droid.DataForm.Styling.CustomDecimalEditorFormatter;

[assembly: ExportRenderer(typeof(CustomRadDataForm), typeof(CustomRadDataFormRenderer))]
namespace SDKBrowser.Droid.DataForm.Styling.CustomDecimalEditorFormatter
{
	public class CustomRadDataFormRenderer : DataFormRenderer
	{
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
