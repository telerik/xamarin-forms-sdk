using System.IO;
using System.Windows.Input;
using SDKBrowser.Common;
using Telerik.Zip;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibrary.Encryption
{
	public class ViewModel : ViewModelBase
	{
		private string input;
		private string encryptionPassword;
		private ICommand encryptionCommand;
		private string decryptionPassword;
		private ICommand decryptionCommand;
		private string output;
		private byte[] bytes;

		public ViewModel()
		{
			this.EncryptionCommand = new Command(this.Encrypt);
			this.DecryptionCommand = new Command(this.Decrypt);
		}

		public string Input
		{
			get
			{
				return this.input;
			}
			set
			{
				if (this.input != value)
				{
					this.input = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string EncryptionPassword
		{
			get
			{
				return this.encryptionPassword;
			}
			set
			{
				if (this.encryptionPassword != value)
				{
					this.encryptionPassword = value;
					this.OnPropertyChanged();
				}
			}
		}

		public ICommand EncryptionCommand
		{
			get
			{
				return this.encryptionCommand;
			}
			set
			{
				if (this.encryptionCommand != value)
				{
					this.encryptionCommand = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string DecryptionPassword
		{
			get
			{
				return this.decryptionPassword;
			}
			set
			{
				if (this.decryptionPassword != value)
				{
					this.decryptionPassword = value;
					this.OnPropertyChanged();
				}
			}
		}

		public ICommand DecryptionCommand
		{
			get
			{
				return this.decryptionCommand;
			}
			set
			{
				if (this.decryptionCommand != value)
				{
					this.decryptionCommand = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string Output
		{
			get
			{
				return this.output;
			}
			set
			{
				if (this.output != value)
				{
					this.output = value;
					this.OnPropertyChanged();
				}
			}
		}



		private void Encrypt(object obj)
		{
			using (Stream targetStream = new MemoryStream())
			{
				DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings();
				encryptionSettings.Password = this.EncryptionPassword ?? string.Empty;

				using (CompressedStream compressedStream = new CompressedStream(targetStream, StreamOperationMode.Write, new DeflateSettings(), false, encryptionSettings))
				{
					StreamWriter writer = new StreamWriter(compressedStream);
					writer.Write(this.Input);
					writer.Flush();
				}

				targetStream.Seek(0, SeekOrigin.Begin);
				this.bytes = new byte[targetStream.Length];
				targetStream.Read(this.bytes, 0, this.bytes.Length);

				targetStream.Seek(0, SeekOrigin.Begin);

				using (StreamReader reader = new StreamReader(targetStream))
				{
					this.Output = reader.ReadToEnd();
				}
			}
		}

		private void Decrypt(object obj)
		{
			try
			{
				using (Stream sourceStream = new MemoryStream())
				{
					sourceStream.Write(this.bytes, 0, this.bytes.Length);
					sourceStream.Seek(0, SeekOrigin.Begin);

					DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings();
					encryptionSettings.Password = this.DecryptionPassword ?? string.Empty;

					using (CompressedStream compressedStream = new CompressedStream(sourceStream, StreamOperationMode.Read, new DeflateSettings(), false, encryptionSettings))
					{
						StreamReader reader = new StreamReader(compressedStream);
						this.Output = reader.ReadToEnd();
					}
				}
			}
			catch
			{
				this.Output = "Can not decompress with this password";
			}
		}
	}
}
