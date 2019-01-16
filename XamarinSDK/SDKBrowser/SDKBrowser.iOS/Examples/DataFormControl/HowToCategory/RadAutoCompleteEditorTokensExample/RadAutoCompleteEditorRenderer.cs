using SDKBrowser.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample;
using SDKBrowser.iOS.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample;
using System.Collections.Generic;
using Telerik.XamarinForms.Common.iOS;
using Telerik.XamarinForms.InputRenderer.iOS;
using TelerikUI;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomRadAutoCompleteDataForm), typeof(RadAutoCompleteEditorRenderer))]
namespace SDKBrowser.iOS.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample
{
    public class RadAutoCompleteEditorRenderer : DataFormRenderer
    {
        protected override void UpdateEditor(TelerikUI.TKDataFormEditor editor, Telerik.XamarinForms.Input.DataForm.IEntityProperty property)
        {
            base.UpdateEditor(editor, property);

            if (property.PropertyName == "Towns")
            {
                var autoCompleteEditor = (TKDataFormAutoCompleteInlineEditor)editor;
                if (autoCompleteEditor.AutoCompleteView.Delegate == null)
                {
                    autoCompleteEditor.AutoCompleteView.Delegate = new CustomAutoCompleteListDelegate(autoCompleteEditor);
                    autoCompleteEditor.AutoCompleteView.DisplayMode = TKAutoCompleteDisplayMode.Tokens;
                }
            }
        }
    }

    public class CustomAutoCompleteListDelegate : TKAutoCompleteDelegate
    {
        private TKDataFormAutoCompleteInlineEditor tKDataFormAutoCompleteInlineEditor;
        private List<string> tokens = new List<string>();

        public CustomAutoCompleteListDelegate(TKDataFormAutoCompleteInlineEditor tKDataFormAutoCompleteInlineEditor)
        {
            this.tKDataFormAutoCompleteInlineEditor = tKDataFormAutoCompleteInlineEditor;
        }

        public override void DidAddToken(TKAutoCompleteTextView autocomplete, TKAutoCompleteToken token)
        {
            this.tokens.Add(token.Text);
            tKDataFormAutoCompleteInlineEditor.Value = this.tokens.ToNSObject();
        }

        public override void DidRemoveToken(TKAutoCompleteTextView autocomplete, TKAutoCompleteToken token)
        {
            this.tokens.Remove(token.Text);
            tKDataFormAutoCompleteInlineEditor.Value = this.tokens.ToNSObject();
        }
    }
}