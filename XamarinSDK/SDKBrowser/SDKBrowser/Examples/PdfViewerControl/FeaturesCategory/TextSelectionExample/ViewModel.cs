using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.PdfViewer.Selection;
using Xamarin.Forms;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.TextSelectionExample
{
    // >> pdfviewer-textselection-viewmodel
    public class ViewModel : NotifyPropertyChangedBase
    {      
        public ViewModel()
        {
            this.GetSelectedTextCommand = new Command(GetSelectedTextCommandExecuted);
        }

        public ICommand GetSelectedTextCommand { get; set; }

        private void GetSelectedTextCommandExecuted(object obj)
        {
            SelectionCommandContext context = (SelectionCommandContext)obj;
            var selection = context.PdfViewer.Document.Selection;
            Application.Current.MainPage.DisplayAlert("Selected Text", selection.GetSelectedText(), "OK");

            lock (selection)
            {
                selection.Clear();
            }
        }
    }
    // << pdfviewer-textselection-viewmodel
}
