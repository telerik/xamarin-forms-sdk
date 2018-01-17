using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.Editors.DataFormEditor
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
        private DateTime lastReviewed = new DateTime(2010, 11, 3);
        private DateTime borrowTime = new DateTime(2010, 11, 3, 8, 0, 0);

        [DisplayOptions(Header = "Name", PlaceholderText = "Book Name")]
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

        [DisplayOptions(Header = "Genre", PlaceholderText = "Select Genre")]
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

        [DisplayOptions(Header = "Target Group")]
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

        [DisplayOptions(Header = "Year")]
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

        [DisplayOptions(Header = "Last Reviewed")]
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

        [DisplayOptions(Header = "Last Reviewed")]
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

        [DisplayOptions(Header = "Published")]
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

        [DisplayOptions(Header = "Due")]
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

        [DisplayOptions(Header = "Rating", Position = 5)]
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