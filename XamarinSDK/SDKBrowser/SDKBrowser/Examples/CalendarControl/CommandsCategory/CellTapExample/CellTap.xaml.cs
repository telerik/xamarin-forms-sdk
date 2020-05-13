using System.Windows.Input;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.CommandsCategory.CellTapExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // >> calendar-commands-celltap
    public partial class CellTap : ContentView
    {
        public CellTap()
        {
            InitializeComponent();

            this.CellTapCommand = new Command(this.OnCellTapped);
            this.BindingContext = this;
        }

        public ICommand CellTapCommand { get; set; }

        private void OnCellTapped(object obj)
        {
            var args = (CalendarDayCell)obj;
            Application.Current.MainPage.DisplayAlert("Cell Tap Command", "You have selected " + args.Date.ToString("dd/MMMM/yyyy"), "OK");
        }
    }
    // << calendar-commands-celltap
}