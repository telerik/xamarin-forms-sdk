using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SDKBrowser.ViewModels;
using Telerik.XamarinForms.DataGrid;

namespace SDKBrowser.Examples.DataGridControl.SelectionCategory
{
    public class ViewModel : ViewModelBase
    {
        private DataGridSelectionMode selectedMode;
        private DataGridSelectionUnit selectedUnit;
        private int selectedIndex;
        private int selectedColumn;
        private bool isPickerEnabled;

        public ViewModel()
        {
            var source = new List<Person>();
            for (int i = 18; i < 70; i++)
            {
                source.Add(new Person() { Age = i, Name = "Name + " + i });
            }
            this.GridSource = source;
            this.SelectionModeSource = Enum.GetValues(typeof(DataGridSelectionMode));
            this.SelectionUnitSource = Enum.GetValues(typeof(DataGridSelectionUnit));
            this.SelectedColumnIndexSource = Enumerable.Range(0, 3).Select(y => y).ToList();
            this.SelectedIndexSource = Enumerable.Range(0, source.Count).Select(x => x).ToList();

            this.SelectedMode = DataGridSelectionMode.Single;
            this.SelectedUnit = DataGridSelectionUnit.Cell;
            this.SelectedColumn = 0;
            this.SelectedIndex = 0;
        }

        public IList GridSource { get; set; }
        public IList SelectionModeSource { get; set; }
        public IList SelectionUnitSource { get; set; }
        public IList SelectedIndexSource { get; set; }
        public IList SelectedColumnIndexSource { get; set; }

        public DataGridSelectionMode SelectedMode
        {
            get
            {
                return this.selectedMode;
            }
            set
            {
                if (this.selectedMode != value)
                {
                    this.selectedMode = value;
                    this.OnPropertyChanged("SelectedMode");
                }
            }
        }

        public DataGridSelectionUnit SelectedUnit
        {
            get
            {
                return this.selectedUnit;
            }
            set
            {
                if (this.selectedUnit != value)
                {
                    this.selectedUnit = value;
                    this.IsPickerEnabled = this.selectedUnit != DataGridSelectionUnit.Row;
                    this.OnPropertyChanged("SelectedUnit");
                }
            }
        }

        public int SelectedIndex
        {
            get
            {
                return this.selectedIndex;
            }
            set
            {
                if (this.selectedIndex != value)
                {
                    this.selectedIndex = value;
                    this.OnPropertyChanged("SelectedIndex");
                }
            }
        }

        public int SelectedColumn
        {
            get
            {
                return this.selectedColumn;
            }
            set
            {
                if (this.selectedColumn != value)
                {
                    this.selectedColumn = value;
                    this.OnPropertyChanged("SelectedColumn");
                }
            }
        }

        public bool IsPickerEnabled
        {
            get
            {
                return this.isPickerEnabled;
            }
            set
            {
                if (this.isPickerEnabled != value)
                {
                    this.isPickerEnabled = value;
                    this.OnPropertyChanged("IsPickerEnabled");
                }
            }
        }
    }
}
