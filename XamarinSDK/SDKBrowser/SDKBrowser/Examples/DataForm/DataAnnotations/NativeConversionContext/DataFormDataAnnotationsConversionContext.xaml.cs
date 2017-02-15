using System;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormDataAnnotationsConversionContext : ContentPage
    {
        public DataFormDataAnnotationsConversionContext()
        {
            InitializeComponent();
            dataForm.RegisterEditor(typeof(DateTime), EditorType.DateEditor);
        }

        private void Commit(object sender, EventArgs e)
        {
            dataForm.CommitAll();
        }
    }
}
