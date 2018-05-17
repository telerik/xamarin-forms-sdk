using System;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ConversionContextExample
{
    public partial class DataFormDataAnnotationsConversionContext : ContentView
    {
        public DataFormDataAnnotationsConversionContext()
        {
            this.InitializeComponent();
            this.dataForm.RegisterEditor(typeof(DateTime), EditorType.DateEditor);
        }

        private void Commit(object sender, EventArgs e)
        {
            this.dataForm.CommitAll();
        }
    }
}
