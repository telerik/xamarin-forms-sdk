using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.ReorderInGroupedListViewExample
{
    // >> listview-grouping-reorderitems-businessobject
    public class Event : NotifyPropertyChangedBase
    {
        public string _content;
        public string _day;

        public string Content
        {
            get { return this._content; }
            set
            {
                if(this._content != value)
                {
                    this._content = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Day
        {
            get { return this._day; }
            set
            {
                if(this._day != value)
                {
                    this._day = value;
                    OnPropertyChanged();
                }
            }
        }
    }
    // << listview-grouping-reorderitems-businessobject
}
