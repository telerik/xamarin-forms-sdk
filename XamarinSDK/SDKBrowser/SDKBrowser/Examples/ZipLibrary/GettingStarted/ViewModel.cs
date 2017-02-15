using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SDKBrowser.Common;
using Telerik.Zip;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibrary.GettingStarted
{
	public class ViewModel : ViewModelBase
	{
		private const string FileSizeSringFormat = "{0} bytes";
		private const string UncompressedFileName = "LoremIpsum.txt";
		private const string CompressedFileName = "LoremIpsum.txt.zip";

		private string compressUnCompressedSize;
		private string compressCompressedSize;
		private List<string> compressionLevelItemsSource;
		private int selectedCompressionLevelIndex;
		private ICommand compressCommand;

		private string unCompressCompressedSize;
		private string unCompressUnCompressedSize;
		private ICommand unCompressCommand;

		public ViewModel()
		{
			this.CompressCommand = new Command(this.CompressFile);
			this.UnCompressCommand = new Command(this.UnCompressFile);

			using (Stream uncompressedFile = GetEmbeddedResourceStream(UncompressedFileName))
			{
				this.CompressUnCompressedSize = string.Format(FileSizeSringFormat, uncompressedFile.Length);
			}

			using (Stream compressedFile = GetEmbeddedResourceStream(CompressedFileName))
			{
				this.UnCompressCompressedSize = string.Format(FileSizeSringFormat, compressedFile.Length);
			}

			this.CompressionLevelItemsSource = new List<string>();

			this.CompressionLevelItemsSource.Add(CompressionLevel.NoCompression.ToString());
			this.compressionLevelItemsSource.Add(CompressionLevel.Fastest.ToString());
			this.compressionLevelItemsSource.Add(CompressionLevel.Optimal.ToString());
			this.compressionLevelItemsSource.Add(CompressionLevel.Best.ToString());
		}

		public string CompressUnCompressedSize
		{
			get
			{
				return this.compressUnCompressedSize;
			}
			set
			{
				if (this.compressUnCompressedSize != value)
				{
					this.compressUnCompressedSize = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string CompressCompressedSize
		{
			get
			{
				return this.compressCompressedSize;
			}
			set
			{
				if (this.compressCompressedSize != value)
				{
					this.compressCompressedSize = value;
					this.OnPropertyChanged();
				}
			}
		}

		public List<string> CompressionLevelItemsSource
		{
			get
			{
				return this.compressionLevelItemsSource;
			}
			set
			{
				if (this.compressionLevelItemsSource != value)
				{
					this.compressionLevelItemsSource = value;
					this.OnPropertyChanged();
				}
			}
		}

		public int SelectedCompressionLevelIndex
		{
			get
			{
				return this.selectedCompressionLevelIndex;
			}
			set
			{
				if (this.selectedCompressionLevelIndex != value)
				{
					this.selectedCompressionLevelIndex = value;
					this.OnPropertyChanged();
				}
			}
		}

		public ICommand CompressCommand
		{
			get
			{
				return this.compressCommand;
			}
			set
			{
				if (this.compressCommand != value)
				{
					this.compressCommand = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string UnCompressUnCompressedSize
		{
			get
			{
				return this.unCompressUnCompressedSize;
			}
			set
			{
				if (this.unCompressUnCompressedSize != value)
				{
					this.unCompressUnCompressedSize = value;
					this.OnPropertyChanged();
				}
			}
		}

		public string UnCompressCompressedSize
		{
			get
			{
				return this.unCompressCompressedSize;
			}
			set
			{
				if (this.unCompressCompressedSize != value)
				{
					this.unCompressCompressedSize = value;
					this.OnPropertyChanged();
				}
			}
		}

		public ICommand UnCompressCommand
		{
			get
			{
				return this.unCompressCommand;
			}
			set
			{
				if (this.unCompressCommand != value)
				{
					this.unCompressCommand = value;
					this.OnPropertyChanged();
				}
			}
		}

		private void CompressFile(object obj)
		{
			this.CompressCompressedSize = string.Empty;

			using (Stream compressedStream = new MemoryStream())
			{
				DeflateSettings compressionSettings = new DeflateSettings();

				string compressionLevel = this.CompressionLevelItemsSource[this.SelectedCompressionLevelIndex];
				compressionSettings.CompressionLevel = (CompressionLevel)Enum.Parse(typeof(CompressionLevel), compressionLevel);

				using (ZipArchive archive = new ZipArchive(compressedStream, ZipArchiveMode.Create, true, null, compressionSettings, null))
				{
					using (Stream uncompressedFileStream = GetEmbeddedResourceStream(UncompressedFileName))
					{
						using (ZipArchiveEntry entry = archive.CreateEntry(UncompressedFileName))
						{
							using (Stream entryStream = entry.Open())
							{
								uncompressedFileStream.CopyTo(entryStream);
							}
						}
					}
				}

				this.CompressCompressedSize = string.Format(FileSizeSringFormat, compressedStream.Length);
			}
		}

		private void UnCompressFile(object obj)
		{
			this.UnCompressUnCompressedSize = string.Empty;

			using (Stream uncompressedStream = new MemoryStream())
			{
				using (Stream compressedFileStream = GetEmbeddedResourceStream(CompressedFileName))
				{
					using (ZipArchive archive = new ZipArchive(compressedFileStream, ZipArchiveMode.Read, true, null))
					{
						using (ZipArchiveEntry entry = archive.Entries.First())
						{
							using (Stream entryStream = entry.Open())
							{
								entryStream.CopyTo(uncompressedStream);
							}
						}
					}
				}

				this.UnCompressUnCompressedSize = string.Format(FileSizeSringFormat, uncompressedStream.Length);
			}
		}

		public static Stream GetEmbeddedResourceStream(string resourceFileName)
		{
			Assembly assembly = typeof(ViewModel).GetTypeInfo().Assembly;

			var resourceNames = assembly.GetManifestResourceNames();

			var resourcePaths = resourceNames
				.Where(x => x.EndsWith(resourceFileName, StringComparison.CurrentCultureIgnoreCase))
				.ToArray();

			if (!resourcePaths.Any())
			{
				throw new Exception(string.Format("Resource ending with {0} not found.", resourceFileName));
			}

			if (resourcePaths.Count() > 1)
			{
				throw new Exception(string.Format("Multiple resources ending with {0} found: {1}{2}", resourceFileName, Environment.NewLine, string.Join(Environment.NewLine, resourcePaths)));
			}

			return assembly.GetManifestResourceStream(resourcePaths.Single());
		}
	}
}