using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using SDKBrowser.Common;
using Telerik.Documents.SpreadsheetStreaming;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessing.GettingStarted
{
    public class GettingStartedViewModel : ViewModelBase
    {
        private string firstCellValue;
        private string secondCellValue;
        private List<string> fontFamiliesItemsSource;
        private int selectedFontFamilyIndex;
        private List<string> fontSizesItemsSource;
        private int selectedFontSizeIndex;
        private bool isBold;
        private bool isItalic;
        private List<string> colorsItemsSource;
        private int selectedFillColorIndex;
        private int selectedTextColorIndex;
        private List<string> underlineItemsSource;
        private int selectedUnderlineIndex;
        private ICommand generateDocumentCommand;

        public GettingStartedViewModel()
        {
            this.FontFamiliesItemsSource = new List<string> { "Calibri", "Arial", "Cambria" };
            this.FontSizesItemsSource = new List<string> { "8", "9", "10", "11", "12", "14", "16" };
            this.ColorsItemsSource = FromEnum(typeof(PredefinedColors));
            this.UnderlineItemsSource = FromEnum(typeof(SpreadUnderlineType));

            this.SelectedFontSizeIndex = 3;
            this.SelectedFillColorIndex = (int)PredefinedColors.NoColor;
            this.SelectedTextColorIndex = (int)PredefinedColors.Black;

            this.GenerateDocumentCommand = new Command(this.GenerateDocument);
        }

        public string FirstCellValue
        {
            get
            {
                return this.firstCellValue;
            }
            set
            {
                if (this.firstCellValue != value)
                {
                    this.firstCellValue = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string SecondCellValue
        {
            get
            {
                return this.secondCellValue;
            }
            set
            {
                if (this.secondCellValue != value)
                {
                    this.secondCellValue = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public List<string> FontFamiliesItemsSource
        {
            get
            {
                return this.fontFamiliesItemsSource;
            }
            set
            {
                if (this.fontFamiliesItemsSource != value)
                {
                    this.fontFamiliesItemsSource = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedFontFamilyIndex
        {
            get
            {
                return this.selectedFontFamilyIndex;
            }
            set
            {
                if (this.selectedFontFamilyIndex != value)
                {
                    this.selectedFontFamilyIndex = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public List<string> FontSizesItemsSource
        {
            get
            {
                return this.fontSizesItemsSource;
            }
            set
            {
                if (this.fontSizesItemsSource != value)
                {
                    this.fontSizesItemsSource = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedFontSizeIndex
        {
            get
            {
                return this.selectedFontSizeIndex;
            }
            set
            {
                if (this.selectedFontSizeIndex != value)
                {
                    this.selectedFontSizeIndex = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public bool IsBold
        {
            get
            {
                return this.isBold;
            }
            set
            {
                if (this.isBold != value)
                {
                    this.isBold = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public bool IsItalic
        {
            get
            {
                return this.isItalic;
            }
            set
            {
                if (this.isItalic != value)
                {
                    this.isItalic = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public List<string> ColorsItemsSource
        {
            get
            {
                return this.colorsItemsSource;
            }
            set
            {
                if (this.colorsItemsSource != value)
                {
                    this.colorsItemsSource = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedFillColorIndex
        {
            get
            {
                return this.selectedFillColorIndex;
            }
            set
            {
                if (this.selectedFillColorIndex != value)
                {
                    this.selectedFillColorIndex = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedTextColorIndex
        {
            get
            {
                return this.selectedTextColorIndex;
            }
            set
            {
                if (this.selectedTextColorIndex != value)
                {
                    this.selectedTextColorIndex = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public List<string> UnderlineItemsSource
        {
            get
            {
                return this.underlineItemsSource;
            }
            set
            {
                if (this.underlineItemsSource != value)
                {
                    this.underlineItemsSource = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public int SelectedUnderlineIndex
        {
            get
            {
                return this.selectedUnderlineIndex;
            }
            set
            {
                if (this.selectedUnderlineIndex != value)
                {
                    this.selectedUnderlineIndex = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public ICommand GenerateDocumentCommand
        {
            get
            {
                return this.generateDocumentCommand;
            }
            set
            {
                if (this.generateDocumentCommand != value)
                {
                    this.generateDocumentCommand = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private async void GenerateDocument()
        {
            SpreadCellFormat format = new SpreadCellFormat();
            format.FontFamily = new SpreadThemableFontFamily(this.FontFamiliesItemsSource[this.SelectedFontFamilyIndex]);
            format.FontSize = int.Parse(this.FontSizesItemsSource[this.SelectedFontSizeIndex]);
            format.IsBold = this.IsBold;
            format.IsItalic = this.IsItalic;

            PredefinedColors selectedFillColor = (PredefinedColors)this.SelectedFillColorIndex;
            PredefinedColors selectedTextColor = (PredefinedColors)this.SelectedTextColorIndex;

            if (selectedFillColor != PredefinedColors.NoColor)
            {
                format.Fill = SpreadPatternFill.CreateSolidFill(ToSpreadColor(selectedFillColor));
            }

            if (selectedTextColor != PredefinedColors.NoColor)
            {
                format.ForeColor = ToSpreadColor(selectedTextColor);
            }

            format.Underline = (SpreadUnderlineType)this.SelectedUnderlineIndex;

            using (MemoryStream stream = new MemoryStream())
            {
                using (IWorkbookExporter workbook = SpreadExporter.CreateWorkbookExporter(SpreadDocumentFormat.Xlsx, stream))
                {
                    using (IWorksheetExporter worksheet = workbook.CreateWorksheetExporter("Sheet1"))
                    {
                        using (IRowExporter row = worksheet.CreateRowExporter())
                        {
                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue(this.FirstCellValue ?? "Sample text");
                                cell.SetFormat(format);
                            }

                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetFormula(this.SecondCellValue ?? "=1+2");
                                cell.SetFormat(format);
                            }
                        }
                    }
                }

                await DependencyService.Get<IXlsxFileViewer>().View(stream, "GettingStarted.xlsx");
            }
        }

        private SpreadThemableColor ToSpreadColor(PredefinedColors selectedColor)
        {
            SpreadColor spreadColor;

            switch (selectedColor)
            {
                case PredefinedColors.Black:
                    {
                        spreadColor = new SpreadColor(0, 0, 0);
                    }
                    break;
                case PredefinedColors.Blue:
                    {
                        spreadColor = new SpreadColor(0, 0, 255);
                    }
                    break;
                case PredefinedColors.Green:
                    {
                        spreadColor = new SpreadColor(0, 255, 0);
                    }
                    break;
                case PredefinedColors.Orange:
                    {
                        spreadColor = new SpreadColor(255, 102, 0);
                    }
                    break;
                case PredefinedColors.Red:
                    {
                        spreadColor = new SpreadColor(255, 0, 0);
                    }
                    break;
                case PredefinedColors.Yellow:
                    {
                        spreadColor = new SpreadColor(255, 255, 0);
                    }
                    break;
                default:
                    {
                        throw new InvalidOperationException();
                    }

            }

            return new SpreadThemableColor(spreadColor);
        }

        private List<string> FromEnum(Type type)
        {
            return new List<string>(Enum.GetNames(type));
        }
    }
}
