using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory
{
    // >> autocompleteview-features-viewmodel
    public class ViewModel
    {
        public ObservableCollection<Client> Source { get; set; }
        public ViewModel()
        {
            this.Source = new ObservableCollection<Client>()
            {
                new Client("Freda Curtis", "fcurtis@mail.com", "available32.png"),
                new Client("Jeffery Francis", "jfrancis@mail.com", "away32.png"),
                new Client("Eva Lawson", "elawson@mail.com", "available32.png"),
                new Client("Emmett Santos", "esantos@mail.com", "busy32.png"),
                new Client("Theresa Bryan", "tbryan@mail.com", "available32.png"),
                new Client("Jenny Fuller", "jfuller@mail.com", "busy32.png"),
                new Client("Terrell Norris", "tnorris@mail.com", "away32.png"),
                new Client("Eric Wheeler", "ewheeler@mail.com", "away32.png"),
                new Client("Nida Carty", "ncarty@mail.com", "away32.png"),
                new Client("Niki Samaniego", "nsamaniego@mail.com", "busy32.png")
            };
        }
    }
    // << autocompleteview-features-viewmodel
}
