using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.DataGrid.FilteringUI
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Players = ViewModel.GetPlayers();
        }

        public ObservableCollection<Player> Players { get; set; }

        private static ObservableCollection<Player> GetPlayers()
        {
            var players = new ObservableCollection<Player>();
            players.Add(new Player("Pepe Reina", 25, "Spain"));
            players.Add(new Player("Jamie Carragher", 23, "England"));
            players.Add(new Player("John Terry", 26, "England"));
            players.Add(new Player("Frank Lampard", 8, "England"));
            players.Add(new Player("Cesc Fàbregas", 4, "Spain"));

            return players;
        }
    }
}
