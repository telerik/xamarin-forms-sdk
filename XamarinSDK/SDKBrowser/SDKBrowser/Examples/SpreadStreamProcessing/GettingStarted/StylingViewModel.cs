using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using SDKBrowser.Common;
using Telerik.Documents.SpreadsheetStreaming;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessing.GettingStarted
{
    public class StylingViewViewModel : ViewModelBase
    {
        private ICommand generateDocumentCommand;
        private List<Book> source;

        public StylingViewViewModel()
        {
            this.Source = new List<Book>
            {
                new Book{ Title = "The Fault in Our Stars ",  Author = "John Green"},
                new Book{ Title = "Divergent",  Author = "Veronica Roth"},
                new Book{ Title = "Gone Girl",  Author = "Gillian Flynn"},
                new Book{ Title = "Clockwork Angel",  Author = "Cassandra Clare"},
                new Book{ Title = "The Martian",  Author = "Andy Weir"},
                new Book{ Title = "Ready Player One",  Author = "Ernest Cline"},
                new Book{ Title = "The Lost Hero",  Author = "Rick Riordan"},
                new Book{ Title = "All the Light We Cannot See",  Author = "Anthony Doerr"},
                new Book{ Title = "Cinder",  Author = "Marissa Meyer"},
                new Book{ Title = "Me Before You",  Author = "Jojo Moyes"},
                new Book{ Title = "The Night Circus",  Author = "Erin Morgenstern"},
            };

            this.GenerateDocumentCommand = new Command(this.GenerateDocument);
        }

        public List<Book> Source
        {
            get
            {
                return this.source;
            }
            set
            {
                if (this.source != value)
                {
                    this.source = value;
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
            var maxTitleCharCount = this.Source.Max(p => p.Title.Length);
            var maxAuthorCharCount = this.Source.Max(p => p.Author.Length);

            using (MemoryStream stream = new MemoryStream())
            {
                using (IWorkbookExporter workbook = SpreadExporter.CreateWorkbookExporter(SpreadDocumentFormat.Xlsx, stream))
                {
                    using (IWorksheetExporter worksheet = workbook.CreateWorksheetExporter("Sheet1"))
                    {
                        using (IWorksheetViewExporter viewExporter = worksheet.CreateWorksheetViewExporter())
                        {
                            // just moving the selection so the bottom border of the header row is visible
                            viewExporter.AddSelectionRange(0, 3, 0, 3);
                        }

                        using (IColumnExporter titleColumn = worksheet.CreateColumnExporter())
                        {
                            titleColumn.SetWidthInCharacters(maxTitleCharCount);
                        }

                        using (IColumnExporter authorColumn = worksheet.CreateColumnExporter())
                        {
                            authorColumn.SetWidthInCharacters(maxAuthorCharCount);
                        }

                        using (IRowExporter row = worksheet.CreateRowExporter())
                        {
                            SpreadCellFormat headerformat = new SpreadCellFormat();
                            headerformat.CellStyle = workbook.CellStyles["Heading 1"];
                            headerformat.HorizontalAlignment = SpreadHorizontalAlignment.Center;

                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Books");
                                cell.SetFormat(headerformat);
                            }

                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetFormat(headerformat);
                            }
                        }

                        using (IRowExporter row = worksheet.CreateRowExporter())
                        {
                            SpreadCellFormat subHeaderformat = new SpreadCellFormat();
                            subHeaderformat.CellStyle = workbook.CellStyles["Heading 2"];

                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Title");
                                cell.SetFormat(subHeaderformat);
                            }

                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Author");
                                cell.SetFormat(subHeaderformat);
                            }
                        }

                        for (int i = 0; i< this.Source.Count; i++)
                        {
                            Book book = this.Source[i];

                            string styleName = i % 2 == 0 ? "20% - Accent1" : "20% - Accent2";

                            SpreadCellFormat format = new SpreadCellFormat();
                            format.CellStyle = workbook.CellStyles[styleName];

                            using (IRowExporter row = worksheet.CreateRowExporter())
                            {
                                using (ICellExporter cell = row.CreateCellExporter())
                                {
                                    cell.SetValue(book.Title);
                                    cell.SetFormat(format);
                                }

                                using (ICellExporter cell = row.CreateCellExporter())
                                {
                                    cell.SetValue(book.Author);
                                    cell.SetFormat(format);
                                }
                            }
                        }

                        worksheet.MergeCells(0, 0, 0, 1);
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