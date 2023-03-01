using Aspose.Pdf;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public sealed class AsposeBenchmarkAdd : IBenchmark
    {
        // Adapted from https://github.com/aspose-pdf/Aspose.PDF-for-.NET/blob/master/Examples/CSharp/AsposePDF/Pages/ConcatenatePdfFiles.cs
        public void Run(string[] fileList)
        {
            using (var file = FileLoader.Get(fileList[0]))
            {
                Document mainFile = new Document(file);

                for (int x = 1; x < fileList.Length; x++)
                {
                    using (var appendFile = FileLoader.Get(fileList[x]))
                    {
                        Document appendDocument = new Document(appendFile);
                        mainFile.Pages.Add(appendDocument.Pages);
                    }
                }
            }
        }
    }
}
