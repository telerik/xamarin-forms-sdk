using System;
using System.IO;
using Telerik.XamarinForms.ImageEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ImageEditorControl.FeaturesCategory.CustomCommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomCommands : ContentView
    {
        public CustomCommands ()
        {
            InitializeComponent ();
        }

        private void OnSaveTapped(object sender, EventArgs e)
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var filePath = Path.Combine(folderPath, "image.jpg");

            // >> imageeditor-custom-save-command
            using (var fileStream = File.Create(filePath))
            {
                this.imageEditor.SaveAsync(fileStream, ImageFormat.Jpeg, 0.9);
            }
            // << imageeditor-custom-save-command
            Application.Current.MainPage.DisplayAlert("", "The Image is saved", "OK");
        }
    }
}