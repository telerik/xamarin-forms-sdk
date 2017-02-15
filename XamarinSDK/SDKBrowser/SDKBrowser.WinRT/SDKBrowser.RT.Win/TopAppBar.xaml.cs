using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Telerik.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace SDKBrowser.WinRT
{
    public sealed partial class TopAppBar : UserControl
    {
        private ObservableCollection<object> topCommands;

        public TopAppBar()
        {
            this.InitializeComponent();

            this.Loaded += TopAppBar_Loaded;

            this.topCommands = new ObservableCollection<object>();
        }



        public object Tracker
        {
            get { return (object)GetValue(TrackerProperty); }
            set { SetValue(TrackerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tracker.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TrackerProperty =
            DependencyProperty.Register("Tracker", typeof(object), typeof(TopAppBar), new PropertyMetadata(null,OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var tp = d as TopAppBar;

            var appBar = e.NewValue as CommandBar;

            if (appBar != null)
            {
                var commands = appBar.PrimaryCommands as IObservableVector<ICommandBarElement>;

                if (commands != null)
                {
                    tp.SubscribeToItemChange(commands);
                }

              
            }
        }

        private void SubscribeToItemChange(IObservableVector<ICommandBarElement> commands)
        {
            commands.VectorChanged += Commands_VectorChanged;
        }

        private void Commands_VectorChanged(IObservableVector<ICommandBarElement> sender, IVectorChangedEventArgs @event)
        {
            topCommands.Clear();
            foreach (AppBarButton item in sender)
            {
                topCommands.Add(new TopAppBarContext { Command = item.Command, Icon = (item.DataContext as Xamarin.Forms.ToolbarItem).Icon.File});
            }

            itemsControl.ItemsSource = topCommands;
        }

        private void TopAppBar_Loaded(object sender, RoutedEventArgs e)
        {
            this.SetBinding(TrackerProperty, new Binding() { Path = new PropertyPath("BottomAppBar") });

            this.DataContext = ElementTreeHelper.FindVisualAncestor<Page>(this);
        }
    }

    public class TopAppBarContext
    {
        public string Icon { get; set; }
        public ICommand Command { get; set; }
    }
}
