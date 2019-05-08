using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;
using SelectionMode = Telerik.XamarinForms.DataControls.ListView.SelectionMode;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.SelectionExample
{
    public partial class Selection : ContentView
    {
        // >> listview-features-selection-csharp
        public Selection()
        {
            this.InitializeComponent();
            listView.ItemsSource = new List<string> { "Tom", "Anna", "Peter", "Teodor", "Lorenzo", "Andrea", "Martin" };
            this.InitializePickers();
        }

        private void InitializePickers()
        {
            selectionModePicker.Items.Add("None");
            selectionModePicker.Items.Add("Single");
            selectionModePicker.Items.Add("Multiple");
            selectionModePicker.SelectedIndexChanged += this.OnSelectionModeChanged;
            selectionModePicker.SelectedIndex = 1;

            selectionGesturePicker.Items.Add("Tap");
            selectionGesturePicker.Items.Add("Hold");
            selectionGesturePicker.SelectedIndexChanged += this.OnSelectionGestureChanged;
            selectionGesturePicker.SelectedIndex = 0;
        }
        // << listview-features-selection-csharp

        // >> listview-features-onselectionchanged-csharp
        private void OnSelectionGestureChanged(object sender, EventArgs e)
        {
            switch ((sender as Picker).SelectedIndex)
            {
                case 0:
                    listView.SelectionGesture = SelectionGesture.Tap;
                    break;
                case 1:
                    listView.SelectionGesture = SelectionGesture.Hold;
                    break;
            }
        }

        private void OnSelectionModeChanged(object sender, EventArgs e)
        {
            switch ((sender as Picker).SelectedIndex)
            {
                case 0:
                    listView.SelectionMode = SelectionMode.None;
                    break;
                case 1:
                    listView.SelectionMode = SelectionMode.Single;
                    break;
                case 2:
                    listView.SelectionMode = SelectionMode.Multiple;
                    break;
            }
        }
        // << listview-features-onselectionchanged-csharp
        private void ListViewSelectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    Application.Current.MainPage.DisplayAlert("Selected item:", (string)item, "OK");
                }
            }
        }
    }
}