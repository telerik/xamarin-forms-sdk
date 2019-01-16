using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.EditorsCategory.EditorsExample
{
    public class Book : NotifyPropertyChangedBase
    {
        private string name;
        private string genre;
        private TargetAudience targetGroup;
        private double year = 1990;
        private bool isPublished;
        private bool isDue;
        private float rating;
        private DateTime lastReviewed = new DateTime(2015, 11, 3);
        private DateTime borrowTime = new DateTime(2015, 11, 3, 8, 0, 0);

        [DisplayOptions(Group= "Add a Book", Header = "Name", PlaceholderText = "Book Name", Position = 0, ColumnPosition = 0, ColumnSpan = 2)]
        [StringLengthValidator(2, int.MaxValue, "Name should be longer than 2 symbols.", null)]
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Genre", PlaceholderText = "Select Genre", Position = 1, ColumnPosition = 0, ColumnSpan = 2)]
        [DataSourceKey("Genre")]
        public string Genre
        {
            get
            {
                return this.genre;
            }
            set
            {
                if (this.genre != value)
                {
                    this.genre = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Target Group", Position = 2, ColumnPosition = 0, ColumnSpan = 2)]
        public TargetAudience TargetGroup
        {
            get
            {
                return this.targetGroup;
            }
            set
            {
                if (this.targetGroup != value)
                {
                    this.targetGroup = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Year", Position = 3, ColumnPosition = 0, ColumnSpan = 2)]
        [NumericalRangeValidator(1990, 2015, 1, "Value must be between 1990 and 2015.")]
        public double Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (this.year != value)
                {
                    this.year = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Last Reviewed: Date", Position = 4, ColumnPosition = 0)]
        public DateTime LastReviewed
        {
            get
            {
                return this.lastReviewed;
            }
            set
            {
                if (this.lastReviewed != value)
                {
                    this.lastReviewed = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Time", Position = 4, ColumnPosition = 1)]
        public DateTime BorrowTime
        {
            get
            {
                return this.borrowTime;
            }
            set
            {
                if (this.borrowTime != value)
                {
                    this.borrowTime = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Published", Position = 5, ColumnPosition = 0)]
        public bool IsPublished
        {
            get
            {
                return this.isPublished;
            }
            set
            {
                if (this.isPublished != value)
                {
                    this.isPublished = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Due", Position = 5, ColumnPosition = 1)]
        public bool IsDue
        {
            get
            {
                return this.isDue;
            }
            set
            {
                if (this.isDue != value)
                {
                    this.isDue = value;
                    this.OnPropertyChanged();
                }
            }
        }

        [DisplayOptions(Group = "Add a Book", Header = "Rating", Position = 6, ColumnSpan = 2)]
        [NumericalRangeValidator(0, 5, 1, "Value must be between 0 and 5.")]
        public float Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                if (this.rating != value)
                {
                    this.rating = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}