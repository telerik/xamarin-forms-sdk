using System;
using SDKBrowser.Common;
using SDKBrowser.Examples.SpreadStreamProcessing.GettingStarted;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessing
{
    public class SpreadStreamProcessingGettingStartedCSharp : ContentPage
    {
        public SpreadStreamProcessingGettingStartedCSharp()
        {
            this.BindingContext = new GettingStartedViewModel();

            Entry firstCellEntry = new Entry();
            firstCellEntry.Placeholder = "Enter some text";
            firstCellEntry.SetBinding(Entry.TextProperty, nameof(GettingStartedViewModel.FirstCellValue));

            Entry secondCellEntry = new Entry();
            secondCellEntry.Placeholder = "Enter a formula example: =5+2";
            secondCellEntry.SetBinding(Entry.TextProperty, nameof(GettingStartedViewModel.SecondCellValue));

            Picker fontFamiliesPicker = new Picker();
            fontFamiliesPicker.Title = "Font family";
            fontFamiliesPicker.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, nameof(GettingStartedViewModel.FontFamiliesItemsSource));
            fontFamiliesPicker.SetBinding(Picker.SelectedIndexProperty, nameof(GettingStartedViewModel.SelectedFontFamilyIndex));

            Picker fontSizesPicker = new Picker();
            fontSizesPicker.Title = "Font size";
            fontSizesPicker.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, nameof(GettingStartedViewModel.FontSizesItemsSource));
            fontSizesPicker.SetBinding(Picker.SelectedIndexProperty, nameof(GettingStartedViewModel.SelectedFontSizeIndex));

            Switch isBoldSwitch = new Switch();
            isBoldSwitch.SetBinding(Switch.IsToggledProperty, nameof(GettingStartedViewModel.IsBold));

            Switch isItalicSwitch = new Switch();
            isItalicSwitch.SetBinding(Switch.IsToggledProperty, nameof(GettingStartedViewModel.IsItalic));

            Picker fillColorPicker = new Picker();
            fillColorPicker.Title = "Fill color";
            fillColorPicker.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, nameof(GettingStartedViewModel.ColorsItemsSource));
            fillColorPicker.SetBinding(Picker.SelectedIndexProperty, nameof(GettingStartedViewModel.SelectedFillColorIndex));

            Picker textColorPicker = new Picker();
            textColorPicker.Title = "Text color";
            textColorPicker.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, nameof(GettingStartedViewModel.ColorsItemsSource));
            textColorPicker.SetBinding(Picker.SelectedIndexProperty, nameof(GettingStartedViewModel.SelectedTextColorIndex));

            Picker UnderlinePicker = new Picker();
            UnderlinePicker.Title = "Underline";
            UnderlinePicker.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, nameof(GettingStartedViewModel.UnderlineItemsSource));
            UnderlinePicker.SetBinding(Picker.SelectedIndexProperty, nameof(GettingStartedViewModel.SelectedUnderlineIndex));

            Button generateXlsxButton = new Button();
            generateXlsxButton.Text = "Generate XLSX document";
            generateXlsxButton.SetBinding(Button.CommandProperty, nameof(GettingStartedViewModel.GenerateDocumentCommand));

            Content = new ScrollView
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        firstCellEntry,
                        secondCellEntry,
                        fontFamiliesPicker,
                        fontSizesPicker,
                        new Label() { Text="Bold" },
                        isBoldSwitch,
                        new Label() { Text="Italic" },
                        isItalicSwitch,
                        fillColorPicker,
                        textColorPicker,
                        UnderlinePicker,
                        generateXlsxButton
                    }
                }
            };
        }
    }
}

