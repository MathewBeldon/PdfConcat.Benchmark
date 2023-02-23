using Aspose.Pdf;
using BenchmarkDotNet.Attributes;

namespace PdfConcat.Benchmark
{
    [MemoryDiagnoser]
    public class AsposeBenchmark
    {
        private readonly string[] _pdfList;
        public AsposeBenchmark()
        {
            _pdfList = Directory.GetFiles(@"files", "*.pdf");
        }

        // Taken from https://github.com/aspose-pdf/Aspose.PDF-for-.NET/blob/master/Examples/CSharp/AsposePDF/Pages/ConcatenatePdfFiles.cs
        [Benchmark(Description = "Aspose Benchmark")]
        [Arguments(4)]
        public void Run(int limit)
        {
            Document mainFile = new Document(_pdfList[0]);

            for (int x = 1; x < limit; x++)
            {
                Document addedDocument = new Document(_pdfList[x]);

                mainFile.Pages.Add(addedDocument.Pages);
            }
        }
    }
}
