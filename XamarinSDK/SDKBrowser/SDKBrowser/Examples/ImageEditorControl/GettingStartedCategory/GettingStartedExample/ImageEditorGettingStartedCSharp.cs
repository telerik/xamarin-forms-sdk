using Telerik.XamarinForms.ImageEditor;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ImageEditorControl.GettingStartedCategory.GettingStartedExample
{
    public class ImageEditorGettingStartedCSharp : ContentView
    {
        public ImageEditorGettingStartedCSharp ()
        {
            // >> imageeditor-getting-started-csharp
            var imageEditor = new RadImageEditor();
            if(Device.RuntimePlatform == Device.UWP)
            {
                imageEditor.Source = "Assets/cat4.jpeg";
            }
            else imageEditor.Source = "cat4.jpeg";

            var toolbar = new RadImageEditorToolbar();
            toolbar.ImageEditor = imageEditor;

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            grid.Children.Add(imageEditor, 0, 0);
            grid.Children.Add(toolbar, 0, 1);

            this.Content = grid;
            // << imageeditor-getting-started-csharp
        }
    }
}