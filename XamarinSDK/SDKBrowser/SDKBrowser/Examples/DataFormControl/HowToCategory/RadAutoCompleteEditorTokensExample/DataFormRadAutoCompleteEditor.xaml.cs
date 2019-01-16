using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.RadAutoCompleteEditorTokensExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormRadAutoCompleteEditor : ContentView
    {
        public DataFormRadAutoCompleteEditor()
        {
            InitializeComponent();
            this.dataForm.Source = new SourceItem();
            this.dataForm.PropertyDataSourceProvider = new DataFormSourceProvider();
            this.dataForm.CommitMode = CommitMode.Manual;

            this.dataForm.RegisterEditor(nameof(SourceItem.Towns), EditorType.AutoCompleteEditor);
        }

        private void CommitButtonClicked(object sender, System.EventArgs e)
        {
            this.dataForm.CommitAll();
            var sourceItem = (SourceItem)this.dataForm.Source;

            if (sourceItem.Towns != null)
            {
                this.townsLabel.Text = "Towns: " + String.Join(", ", sourceItem.Towns);
            }
        }
    }
}