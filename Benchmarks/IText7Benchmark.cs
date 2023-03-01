using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public class IText7Benchmark : IBenchmark
    {
        // Adapted from https://itextpdf.com/demos/merge-pdf-files-for-free-online
        public void Run(string[] fileList)
        {
            using (Stream stream = new MemoryStream())
            using (var file = FileLoader.Get(fileList[0]))
            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(file), new PdfWriter(stream)))
            {
                PdfMerger merger = new PdfMerger(pdfDocument);

                for (int i = 1; i < fileList.Length; i++)
                {
                    using (var appendFile = FileLoader.Get(fileList[i]))
                    using (PdfDocument appendPdfDocument = new PdfDocument(new PdfReader(appendFile)))
                    {
                        merger.Merge(appendPdfDocument, 1, appendPdfDocument.GetNumberOfPages());
                    }
                }
            }
        }
    }
}
