using SDKBrowser.Examples.DataGrid.Selection;
using System;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticSelection : ContentPage
    {
        public ProgrammaticSelection()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }

        private void SelectItem(object sender, EventArgs e)
        {
            this.SelectItem(true);
        }

        private void DeselectItem(object sender, EventArgs e)
        {
            this.SelectItem(false);
        }

        private void SelectItem(bool select)
        {
            var source = (this.BindingContext as ViewModel).GridSource;
            var selectedItem = source[this.siPicker.SelectedIndex];

            if (this.grid.SelectionUnit == DataGridSelectionUnit.Row)
            {
               if(select)
               {
                    this.grid.SelectItem(selectedItem);
               }
               else
               {
                    this.grid.DeselectItem(selectedItem);
                }
            }
            else
            {
                var selectedColumn = this.grid.Columns[this.cPicker.SelectedIndex];

                if(select)
                {
                    this.grid.SelectCell(new DataGridCellInfo(selectedItem, selectedColumn));
                }
                else
                {
                    this.grid.DeselectCell(new DataGridCellInfo(selectedItem, selectedColumn));
                }
            }
        }

        private void SelectAll(object sender, EventArgs e)
        {
            this.grid.SelectAll();
        }

        private void DeselectAll(object sender, EventArgs e)
        {
            this.grid.DeselectAll();
        }
    }
}