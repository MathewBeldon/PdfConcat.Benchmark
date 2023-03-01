using Aspose.Pdf;
using Aspose.Pdf.Facades;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public class AsposeBenchmarkConcat : IBenchmark
    {
        // Adapted from https://docs.aspose.com/pdf/net/concatenate-pdf-documents/#concatenate-array-of-pdf-files-using-streams
        public void Run(string[] fileList)
        {
            var pdfEditor = new PdfFileEditor();
            using (var outputFile = new MemoryStream())
            {
                pdfEditor.Concatenate(FileLoader.GetAll(fileList), outputFile);
            }
        }
    }
}
