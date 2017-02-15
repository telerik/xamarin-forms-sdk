using SDKBrowser.Common;
using SDKBrowser.Examples.ZipLibrary.GettingStarted;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibrary
{
    public class ZipLibraryGettingStartedCSharp : ContentPage
	{
		public ZipLibraryGettingStartedCSharp()
		{
			this.BindingContext = new ViewModel();

			Grid grid = new Grid();

			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
			grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

			grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
			grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });

			Label compressUncompressedSizeText = new Label() { Text = "Uncompressed size" };
			grid.Children.Add(compressUncompressedSizeText, 0, 0);

			Label compressUncompressedSizeValue = new Label();
			compressUncompressedSizeValue.SetBinding(Label.TextProperty, new Binding(nameof(ViewModel.CompressUnCompressedSize)));
			grid.Children.Add(compressUncompressedSizeValue, 1, 0);

			Label compressCompressedSizeText = new Label() { Text = "Compressed size" };
			grid.Children.Add(compressCompressedSizeText, 0, 1);

			Label compressCompressedSizeValue = new Label();
			compressCompressedSizeValue.SetBinding(Label.TextProperty, new Binding(nameof(ViewModel.CompressCompressedSize)));
			grid.Children.Add(compressCompressedSizeValue, 1, 1);

			Label compressCompressionLevelText = new Label() { Text = "Compression level" };
			compressCompressionLevelText.VerticalTextAlignment = TextAlignment.Center;
			grid.Children.Add(compressCompressionLevelText, 0, 2);

			Picker compressCompressionLevelValue = new Picker();
			compressCompressionLevelValue.SetBinding(PickerItemsSourceAttachedProperty.ItemsSourceProperty, new Binding(nameof(ViewModel.CompressionLevelItemsSource)));
			compressCompressionLevelValue.SetBinding(Picker.SelectedIndexProperty, new Binding(nameof(ViewModel.SelectedCompressionLevelIndex)));
			compressCompressionLevelValue.Title = "Compression level";
			grid.Children.Add(compressCompressionLevelValue, 1, 2);

			Button compressButton = new Button();
			compressButton.Text = "Compress";
			compressButton.SetBinding(Button.CommandProperty, new Binding(nameof(ViewModel.CompressCommand)));
			compressButton.Margin = new Thickness(0, 0, 0, 20);
			grid.Children.Add(compressButton, 0, 3);
			Grid.SetColumnSpan(compressButton, 2);

			Label uncompressCompressedSizeText = new Label() { Text = "Compressed size" };
			grid.Children.Add(uncompressCompressedSizeText, 0, 4);

			Label uncompressCompressedSizeValue = new Label();
			uncompressCompressedSizeValue.SetBinding(Label.TextProperty, new Binding(nameof(ViewModel.UnCompressCompressedSize)));
			grid.Children.Add(uncompressCompressedSizeValue, 1, 4);

			Label uncompressUncompressedSizeText = new Label() { Text = "Uncompressed size" };
			grid.Children.Add(uncompressUncompressedSizeText, 0, 5);

			Label uncompressUncompressedSizeValue = new Label();
			uncompressUncompressedSizeValue.SetBinding(Label.TextProperty, new Binding(nameof(ViewModel.UnCompressUnCompressedSize)));
			grid.Children.Add(uncompressUncompressedSizeValue, 1, 5);

			Button uncompressButton = new Button();
			uncompressButton.Text = "Uncompress";
			uncompressButton.SetBinding(Button.CommandProperty, new Binding(nameof(ViewModel.UnCompressCommand)));
			grid.Children.Add(uncompressButton, 0, 6);
			Grid.SetColumnSpan(uncompressButton, 2);

			Content = new StackLayout
			{
				Children = {
					grid
				}
			};
		}
	}
}

