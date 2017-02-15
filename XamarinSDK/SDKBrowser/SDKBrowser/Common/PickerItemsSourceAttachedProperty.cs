using System.Collections.Generic;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
	public static class PickerItemsSourceAttachedProperty
	{
		public static readonly BindableProperty ItemsSourceProperty =
			BindableProperty.CreateAttached("ItemsSource", typeof(IEnumerable<string>), typeof(Picker), null, BindingMode.OneWay, null, OnItemsSourcePropertyChanged);

		public static IEnumerable<string> GetItemsSource(BindableObject view)
		{
			return (IEnumerable<string>)view.GetValue(ItemsSourceProperty);
		}

		public static void SetItemsSource(BindableObject view, IEnumerable<string> value)
		{
			view.SetValue(ItemsSourceProperty, value);
		}

		private static void OnItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			Picker picker = bindable as Picker;

			picker.Items.Clear();

			IEnumerable<string> items = newValue as IEnumerable<string>;

			foreach (string item in items)
			{
				picker.Items.Add(item);
			}
		}
	}
}
