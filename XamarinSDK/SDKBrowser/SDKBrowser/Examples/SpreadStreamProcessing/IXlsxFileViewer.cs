using System.IO;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.SpreadStreamProcessing
{
	public interface IXlsxFileViewer
	{
		Task View(Stream stream, string filename);
	}
}
