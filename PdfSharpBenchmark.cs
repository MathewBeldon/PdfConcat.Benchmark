using BenchmarkDotNet.Attributes;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfConcat.Benchmark
{
    [MemoryDiagnoser]
    public class PdfSharpBenchmark
    {

        private readonly string[] _pdfList;
        public PdfSharpBenchmark()
        {
            _pdfList = Directory.GetFiles(@"files", "*.pdf");
        }

        // Taken from http://www.pdfsharp.net/wiki/ConcatenateDocuments-sample.ashx
        [Arguments(4)]
        [Arguments(100)]
        [Benchmark(Description = "PdfSharp Benchmark")]
        public void Run(int limit)
        {
            using (PdfDocument outputDocument = new())
            {
                for (int x = 0; x < limit; x++)
                {
                    using (var inputDocument = PdfReader.Open(_pdfList[x], PdfDocumentOpenMode.Import))
                    {
                        int count = inputDocument.PageCount;
                        for (int idx = 0; idx < count; idx++)
                        {
                            PdfPage page = inputDocument.Pages[idx];
                            outputDocument.AddPage(page);
                        }
                    }
                }
            }
        }
    }
}
