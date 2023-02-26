using Aspose.Pdf;
using BenchmarkDotNet.Attributes;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public class AsposeBenchmark : IBenchmark
    {
        // Taken from https://github.com/aspose-pdf/Aspose.PDF-for-.NET/blob/master/Examples/CSharp/AsposePDF/Pages/ConcatenatePdfFiles.cs
        public void Run(string[] fileList, int pageCount)
        {
            Document mainFile = new Document(fileList[0]);

            for (int x = 1; x < pageCount; x++)
            {
                Document addedDocument = new Document(fileList[x]);

                mainFile.Pages.Add(addedDocument.Pages);
            }
        }
    }
}
