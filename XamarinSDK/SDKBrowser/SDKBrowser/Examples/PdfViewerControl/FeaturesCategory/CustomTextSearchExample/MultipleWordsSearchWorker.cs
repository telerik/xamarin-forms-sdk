using System;
using System.Text;
using Telerik.Windows.Documents.Fixed.Search;
using Telerik.XamarinForms.PdfViewer;

namespace SDKBrowser.Examples.PdfViewerControl.FeaturesCategory.CustomTextSearchExample
{
    // >> pdfviewer-textsearchworker
    public class MultipleWordsSearchWorker : TextSearchWorker
    {
        protected override TextSearchResult Search(SearchContext context)
        {
            string regex = GetMultiWordRegex(context.Text);
            TextSearchOptions regexOptions = new TextSearchOptions { UseRegularExpression = true };
            SearchContext newContext = new SearchContext(context.PdfViewer, context.Document, regex, regexOptions, context.SearchProgress, context.CancellationToken);

            return base.Search(newContext);
        }

        private static string GetMultiWordRegex(string text)
        {
            string[] words = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append("|");
                }

                string expr = string.Format(@"({0})", words[i]);
                sb.Append(expr);
            }

            return sb.ToString();
        }
    }
    // << pdfviewer-textsearchworker
}
