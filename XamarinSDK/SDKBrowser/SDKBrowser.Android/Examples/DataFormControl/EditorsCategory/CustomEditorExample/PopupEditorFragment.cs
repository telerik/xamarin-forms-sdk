using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Telerik.Widget.Dataform.Engine;

namespace SDKBrowser.Droid.Examples.DataFormControl.EditorsCategory.CustomEditorExample
{
    public class PopupEditorFragment : DialogFragment, AdapterView.IOnItemClickListener, INotifyPropertyChanged
    {
        private readonly NotifyPropertyChangedBase notifier = new NotifyPropertyChangedBase();
        private IList<PopupItem> items;

        public PopupEditorFragment(IList<PopupItem> items)
        {
            this.items = items;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootLayout = inflater.Inflate(Resource.Layout.dataform_popup_editor_fragment, null);
            ListView mainList = (ListView) rootLayout.FindViewById(Resource.Id.dataform_popup_editor_list);
            mainList.Adapter = new CustomAdapter(this.Activity, this.items);
            mainList.OnItemClickListener = this;

            return rootLayout;
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            this.notifier.NotifyListeners("Title", this.items[position].Title);
            this.Dismiss();
        }

        public void AddPropertyChangedListener(IPropertyChangedListener propertyChangeListener)
        {
            this.notifier.AddPropertyChangedListener(propertyChangeListener);
        }

        public void RemovePropertyChangedListener(IPropertyChangedListener propertyChangeListener)
        {
            this.notifier.RemovePropertyChangedListener(propertyChangeListener);
        }

        public class CustomAdapter : BaseAdapter
        {
            private Context context;
            private IList<PopupItem> items;

            public CustomAdapter(Context context, IList<PopupItem> items)
            {
                this.context = context;
                this.items = items;
            }

            public override int Count
            {
                get
                {
                    return this.items.Count;
                }
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return this.items[position].Title.ToString();
            }

            public override long GetItemId(int position)
            {
                return this.items[position].GetHashCode();
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                View layoutRoot = LayoutInflater.From(this.context).Inflate(Resource.Layout.dataform_popup_editor_list_item, null);

                TextView title = (TextView) layoutRoot.FindViewById(Resource.Id.listItemTitle);
                title.Text = this.items[position].Title;

                return layoutRoot;
            }
        }
    }
}