using PdfConcat.Benchmark.Benchmarks.Contracts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace PdfConcat.Benchmark.Benchmarks
{
    public class PdfSharpBenchmark : IBenchmark
    {
        // Adapted from http://www.pdfsharp.net/wiki/ConcatenateDocuments-sample.ashx
        public void Run(string[] fileList)
        {
            using (Stream stream = new MemoryStream())
            using (PdfDocument outputDocument = new())
            {
                for (int x = 0; x < fileList.Length; x++)
                {
                    using (var file = FileLoader.Get(fileList[x]))
                    using (var inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                    {
                        for (int page = 0; page < inputDocument.PageCount; page++)
                        {
                            outputDocument.AddPage(inputDocument.Pages[page]);
                        }
                    }
                }
                outputDocument.Save(stream);
            }
        }
    }
}