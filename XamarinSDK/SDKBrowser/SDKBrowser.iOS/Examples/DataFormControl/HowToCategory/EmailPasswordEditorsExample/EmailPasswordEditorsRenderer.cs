using SDKBrowser.Examples.DataFormControl.HowToCategory.EmailPasswordEditorsExample;
using SDKBrowser.iOS.Examples.DataFormControl.HowToCategory.EmailPasswordEditorsExample;
using System;
using Telerik.XamarinForms.InputRenderer.iOS;
using TelerikUI;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEmailPasswordDataForm), typeof(EmailPasswordEditorsRenderer))]
namespace SDKBrowser.iOS.Examples.DataFormControl.HowToCategory.EmailPasswordEditorsExample
{
    // >> dataform-howto-emailpasswordeditors-renderer
    public class EmailPasswordEditorsRenderer : DataFormRenderer
    {
        protected override Type GetCustomEditorType(string propertyName, Type propertyType)
        {
            if (propertyName == "Email")
            {
                return typeof(TKDataFormEmailEditor);
            }

            if (propertyName == "Password")
            {
                return typeof(TKDataFormPasswordEditor);
            }

            return base.GetCustomEditorType(propertyName, propertyType);
        }
    }
    // << dataform-howto-emailpasswordeditors-renderer
}