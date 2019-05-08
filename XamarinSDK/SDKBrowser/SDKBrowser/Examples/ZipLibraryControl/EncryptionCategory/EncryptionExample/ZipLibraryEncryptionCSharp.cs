using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibraryControl.EncryptionCategory.EncryptionExample
{
	public class ZipLibraryEncryptionCSharp : ContentView
	{
		public ZipLibraryEncryptionCSharp()
		{
			this.BindingContext = new ViewModel();

			Editor inputEditor = new Editor();
			inputEditor.SetBinding(Editor.TextProperty, nameof(ViewModel.Input), BindingMode.OneWayToSource);
			inputEditor.HeightRequest = 100;

			Entry encryptionPassword = new Entry();
			encryptionPassword.Placeholder = "Encryption  Password";
			encryptionPassword.SetBinding(Entry.TextProperty, nameof(ViewModel.EncryptionPassword), BindingMode.OneWayToSource);

			Button encryptButton = new Button();
			encryptButton.Text = "Encrypt";
			encryptButton.SetBinding(Button.CommandProperty, nameof(ViewModel.EncryptionCommand));

			Entry decryptionPassword = new Entry();
			decryptionPassword.Placeholder = "Decryption Password";
			decryptionPassword.SetBinding(Entry.TextProperty, nameof(ViewModel.DecryptionPassword), BindingMode.OneWayToSource);

			Button decryptionButton = new Button();
			decryptionButton.Text = "Decryption";
			decryptionButton.SetBinding(Button.CommandProperty, nameof(ViewModel.DecryptionCommand));

			Label output = new Label();
			output.HeightRequest = 100;
			output.LineBreakMode = LineBreakMode.WordWrap;
			output.SetBinding(Label.TextProperty, nameof(ViewModel.Output));

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Children = {
						new Label { Text = "Write some text:" },
						new Frame { Content = inputEditor, OutlineColor = Color.Gray, BackgroundColor = Color.Transparent, Padding = new Thickness(0), HasShadow = false },
						encryptionPassword,
						encryptButton,
						decryptionPassword,
						decryptionButton,
						new Label { Text ="Decrypted text:" },
						output
					}
				}
			};
		}
	}
}
