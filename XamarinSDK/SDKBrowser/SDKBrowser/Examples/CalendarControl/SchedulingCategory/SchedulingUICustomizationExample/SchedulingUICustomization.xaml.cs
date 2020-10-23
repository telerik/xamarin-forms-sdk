using SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUICustomizationExample.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUICustomizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulingUICustomization : ContentView
    {
        private static ResourceDictionary CustomSchedulingResourceDictionary = new CustomSchedulingResources();

        ViewModel vm;
        public SchedulingUICustomization()
        {
            InitializeComponent();
            this.vm = new ViewModel();
            this.BindingContext = this.vm;

            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                if (Application.Current.MainPage.Navigation.NavigationStack.Count > 0)
                {
                    int index = Application.Current.MainPage.Navigation.NavigationStack.Count - 1;
                    var currentPage = Application.Current.MainPage.Navigation.NavigationStack[index];
                    currentPage.Disappearing += this.CurrentPage_Disappearing;
                    currentPage.Appearing += this.CurrentPage_Appearing;
                }
            });
        }

        private void CurrentPage_Appearing(object sender, System.EventArgs e)
        {
            var applicationMergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (!applicationMergedDictionaries.Contains(CustomSchedulingResourceDictionary))
            {
                Application.Current.Resources.MergedDictionaries.Add(CustomSchedulingResourceDictionary);
            }
        }

        private void CurrentPage_Disappearing(object sender, System.EventArgs e)
        {
            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                if (Application.Current.MainPage.Navigation.ModalStack.Count == 0)
                {
                    Application.Current.Resources.MergedDictionaries.Remove(CustomSchedulingResourceDictionary);
                }
            });
        }
    }
}