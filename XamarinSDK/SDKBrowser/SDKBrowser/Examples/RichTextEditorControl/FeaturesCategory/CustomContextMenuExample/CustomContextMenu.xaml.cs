using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.CustomContextMenuExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomContextMenu : ContentView
    {
        public CustomContextMenu()
        {
            InitializeComponent();

            // >> richtexteditor-contextmenu-setvm
            this.BindingContext = new ViewModel();
            // << richtexteditor-contextmenu-setvm

            var htmlSource = @"<h4>One of the Most Beautiful Islands on Earth - Tenerife</h4>
                        <p><strong>Tenerife</strong> is the largest and most populated island of the eight <a href='https://en.wikipedia.org/wiki/Canary_Islands' target='_blank'>Canary Islands</a>.</p>
                        <p style='color:#808080'>It is also the most populated island of <strong>Spain</strong>, with a land area of <i>2,034.38 square kilometers</i> and <i>904,713</i> inhabitants, 43% of the total population of the <strong>Canary Islands</strong>.</p>";
            this.richTextEditor.Source = RichTextSource.FromString(htmlSource);
        }
    }
}
