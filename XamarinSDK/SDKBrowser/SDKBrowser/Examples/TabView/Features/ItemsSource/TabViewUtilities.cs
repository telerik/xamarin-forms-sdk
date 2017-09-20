using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabView
{
    public static class TabViewUtilities
    {
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.CreateAttached(
            "ItemsSource", typeof(IEnumerable), typeof(TabViewUtilities), null, BindingMode.OneWay, null, ItemsSourceChanged);

        public static readonly BindableProperty ItemHeaderTemplateProperty = BindableProperty.CreateAttached(
            "ItemHeaderTemplate", typeof(ControlTemplate), typeof(TabViewUtilities), null, BindingMode.OneWay, null, ItemHeaderTemplateChanged);

        public static readonly BindableProperty ItemContentTemplateProperty = BindableProperty.CreateAttached(
            "ItemContentTemplate", typeof(ControlTemplate), typeof(TabViewUtilities), null, BindingMode.OneWay, null, ItemContentTemplateChanged);

        private static List<Info> infos = new List<Info>();

        public static IEnumerable GetItemsSource(BindableObject view)
        {
            return (IEnumerable)view.GetValue(ItemsSourceProperty);
        }

        public static void SetItemsSource(BindableObject view, IEnumerable value)
        {
            view.SetValue(ItemsSourceProperty, value);
        }

        public static ControlTemplate GetItemHeaderTemplate(BindableObject view)
        {
            return (ControlTemplate)view.GetValue(ItemHeaderTemplateProperty);
        }

        public static void SetItemHeaderTemplate(BindableObject view, ControlTemplate value)
        {
            view.SetValue(ItemHeaderTemplateProperty, value);
        }

        public static ControlTemplate GetItemContentTemplate(BindableObject view)
        {
            return (ControlTemplate)view.GetValue(ItemContentTemplateProperty);
        }

        public static void SetItemContentTemplate(BindableObject view, ControlTemplate value)
        {
            view.SetValue(ItemContentTemplateProperty, value);
        }

        private static void ItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            RadTabView tabView = (RadTabView)bindable;
            IEnumerable newItemsSource = (IEnumerable)newValue;

            RemoveAllTabViewItems(tabView);
            INotifyCollectionChanged itemsSource = oldValue as INotifyCollectionChanged;
            if (itemsSource != null)
            {
                itemsSource.CollectionChanged -= ItemsSource_CollectionChanged;
                RemoveFromInfo(itemsSource, tabView);
            }

            if (newItemsSource != null)
            {
                foreach (object item in newItemsSource)
                {
                    AddTabViewItem(tabView, item);
                }

                itemsSource = newValue as INotifyCollectionChanged;
                if (itemsSource != null)
                {
                    itemsSource.CollectionChanged += ItemsSource_CollectionChanged;
                    AddToInfo(itemsSource, tabView);
                }
            }
        }

        private static void ItemHeaderTemplateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            RadTabView tabView = (RadTabView)bindable;
            ControlTemplate template = (ControlTemplate)newValue;

            foreach (TabViewItem tabItem in tabView.Items)
            {
                tabItem.Header.ControlTemplate = template;
            }
        }

        private static void ItemContentTemplateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            RadTabView tabView = (RadTabView)bindable;
            ControlTemplate template = (ControlTemplate)newValue;

            foreach (TabViewItem tabItem in tabView.Items)
            {
                tabItem.Content = new BindableView { ControlTemplate = template };
            }
        }

        private static void InsertTabViewItem(RadTabView tabView, object item, int index)
        {
            TabViewItem tabItem = new TabViewItem();
            tabItem.Header.ControlTemplate = GetItemHeaderTemplate(tabView);
            tabItem.BindingContext = item;
            tabItem.Content = new BindableView { ControlTemplate = GetItemContentTemplate(tabView) };
            tabView.Items.Insert(index, tabItem);
        }

        private static void AddTabViewItem(RadTabView tabView, object item)
        {
            InsertTabViewItem(tabView, item, tabView.Items.Count);
        }

        private static void RemoveTabViewItem(RadTabView tabView, int i)
        {
            TabViewItem tabItem = tabView.Items[i];
            tabItem.BindingContext = null;
            tabItem.Header.ControlTemplate = null;
            tabItem.Content = null;
            tabView.Items.RemoveAt(i);
        }

        private static void RemoveAllTabViewItems(RadTabView tabView)
        {
            for (int i = tabView.Items.Count - 1; i >= 0; i--)
            {
                RemoveTabViewItem(tabView, i);
            }
        }

        private static void AddToInfo(INotifyCollectionChanged itemsSource, RadTabView tabView)
        {
            if (itemsSource == null)
            {
                return;
            }

            Info info = GetOrCreateInfo(itemsSource);
            info.tabViews.Add(new WeakReference(tabView));
        }

        private static void RemoveFromInfo(INotifyCollectionChanged itemsSource, RadTabView tabView)
        {
            if (itemsSource == null)
            {
                return;
            }

            Info info = TryGetInfo(itemsSource);
            if (info != null)
            {
                info.tabViews.RemoveAll(wr => wr.Target == tabView);
            }
        }

        private static void ItemsSource_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            INotifyCollectionChanged itemsSource = (INotifyCollectionChanged)sender;
            Info info = TryGetInfo(itemsSource);
            if (info == null)
            {
                return;
            }

            foreach (WeakReference wr in info.tabViews)
            {
                RadTabView tabView = (RadTabView)wr.Target;
                if (tabView == null)
                {
                    continue;
                }

                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        AddTabViewItem(tabView, e.NewItems[0]);
                        break;
                    case NotifyCollectionChangedAction.Move:
                        tabView.Items.Move(e.OldStartingIndex, e.NewStartingIndex);
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        RemoveTabViewItem(tabView, e.OldStartingIndex);
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        RemoveTabViewItem(tabView, e.OldStartingIndex);
                        InsertTabViewItem(tabView, e.NewItems[0], e.NewStartingIndex);
                        break;
                    case NotifyCollectionChangedAction.Reset:
                        RemoveAllTabViewItems(tabView);
                        break;
                    default:
                        break;
                }
            }
        }

        private static Info GetOrCreateInfo(INotifyCollectionChanged itemsSource)
        {
            Info info = TryGetInfo(itemsSource);
            if (info == null)
            {
                info = new Info { itemsSource = new WeakReference(itemsSource) };
                infos.Add(info);
            }

            return info;
        }

        private static Info TryGetInfo(INotifyCollectionChanged itemsSource)
        {
            Info info = infos.FirstOrDefault(i => i.itemsSource.Target == itemsSource);
            return info;
        }

        class Info
        {
            internal WeakReference itemsSource;
            internal List<WeakReference> tabViews = new List<WeakReference>();
        }

        /// <summary>
        /// A ContentView that propagates its BindingContext to its children. 
        /// </summary>
        class BindableView : ContentView
        {
            private List<Element> children = new List<Element>();
            
            protected override void OnChildAdded(Element child)
            {
                base.OnChildAdded(child);

                this.children.Add(child);
                SetInheritedBindingContext(child, this.BindingContext);
            }

            protected override void OnChildRemoved(Element child)
            {
                base.OnChildRemoved(child);

                this.children.Remove(child);
                SetInheritedBindingContext(child, null);
            }

            protected override void OnBindingContextChanged()
            {
                base.OnBindingContextChanged();

                object bindingContext = this.BindingContext;
                foreach (Element child in this.children)
                {
                    SetInheritedBindingContext(child, bindingContext);
                }
            }
        }
    }
}

