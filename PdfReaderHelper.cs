using System.Text;
using UglyToad.PdfPig;

namespace WindowsFormsApp2
{
    public static class PdfReaderHelper
    {
        public static string ReadPdf(string path)
        {
            StringBuilder sb = new StringBuilder();

            using (PdfDocument document = PdfDocument.Open(path))
            {
                foreach (var page in document.GetPages())
                {
                    sb.AppendLine(page.Text);
                }
            }

            return sb.ToString();
        }
    }
}