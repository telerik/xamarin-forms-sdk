using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.SegmentControl.FeaturesCategory.SelectionExample
{
    // >> segmentcontrol-features-selection-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.Categories = new ObservableCollection<string>() { "Popular", "Library", "Playlists", "Friends" };
            this.SelectedCategory = 2;
        }

        public ObservableCollection<string> Categories { get; set; }
        public int SelectedCategory { get; set; }
    }
    // << segmentcontrol-features-selection-viewmodel
}
