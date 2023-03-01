using IronPdf;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public sealed class IronPdfBenchmarkAppend : IBenchmark
    {
        // Adapted from https://ironpdf.com/examples/copy-pdf-page-to-another-pdf-file/
        public void Run(string[] fileList)
        {
            using (var file = FileLoader.Get(fileList[0]))
            {
                var mergePdf = new PdfDocument(file);

                for (int i = 1; i < fileList.Length; i++)
                {
                    using (var appendFile = FileLoader.Get(fileList[i]))
                    {
                        mergePdf.AppendPdf(new PdfDocument(appendFile));
                    }
                }
            }
        }
    }
}
