using System;
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
            this.GetSelectedTextCommand = new DisplaySelectedTextCommand();
        }

        public ICommand GetSelectedTextCommand { get; set; }

        class DisplaySelectedTextCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                SelectionCommandContext context = parameter as SelectionCommandContext;
                return context != null;
            }

            public void Execute(object parameter)
            {
                SelectionCommandContext context = (SelectionCommandContext)parameter;
                var selection = context.PdfViewer.Document.Selection;
                Application.Current.MainPage.DisplayAlert("Selected Text", selection.GetSelectedText(), "OK");

                lock (selection)
                {
                    selection.Clear();
                }
            }
        }
    }

    // << pdfviewer-textselection-viewmodel
}
