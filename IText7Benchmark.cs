using BenchmarkDotNet.Attributes;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;

namespace PdfConcat.Benchmark
{
    [MemoryDiagnoser]
    public class IText7Benchmark
    {
        private readonly string[] _pdfList;
        public IText7Benchmark()
        {
            _pdfList = Directory.GetFiles(@"files", "*.pdf");
        }

        // Taken from https://itextpdf.com/demos/merge-pdf-files-for-free-online
        [Arguments(4)]
        [Arguments(100)]
        [Benchmark(Description = "iText7 Benchmark")]
        public void Run(int limit)
        {
            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(_pdfList[0]), new PdfWriter(@"C:/source/merged.pdf")))
            {
                for (int i = 1; i < limit; i++)
                {
                    using (PdfDocument pdfDocument2 = new PdfDocument(new PdfReader(_pdfList[i])))
                    {
                        PdfMerger merger = new PdfMerger(pdfDocument);
                        merger.Merge(pdfDocument2, 1, pdfDocument2.GetNumberOfPages());
                    }
                }
            }
        }
    }
}
