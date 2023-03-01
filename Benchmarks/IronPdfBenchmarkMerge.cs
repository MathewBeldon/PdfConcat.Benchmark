using IronPdf;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark.Benchmarks
{
    public sealed class IronPdfBenchmarkMerge : IBenchmark
    {
        // Adapted from https://ironpdf.com/examples/merge-pdfs/
        public void Run(string[] fileList)
        {
            using (var file = FileLoader.Get(fileList[0]))
            {
                var mergePdf = new PdfDocument(file);

                for (int i = 1; i < fileList.Length; i++)
                {
                    using (var appendFile = FileLoader.Get(fileList[i]))
                    using (var pdfFile = new PdfDocument(appendFile))
                    {
                        mergePdf = PdfDocument.Merge(mergePdf, pdfFile);
                    }
                }
            }
        }
    }
}
