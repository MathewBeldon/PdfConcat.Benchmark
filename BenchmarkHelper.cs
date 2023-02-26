using BenchmarkDotNet.Attributes;
using PdfConcat.Benchmark.Benchmarks;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark
{

    [MemoryDiagnoser]
    public class BenchmarkHelper
    {
        private readonly IBenchmark _iText7Benchmark = new IText7Benchmark();
        private readonly IBenchmark _asposeBenchmark = new AsposeBenchmark();
        private readonly IBenchmark _pdfSharpBenchmark = new PdfSharpBenchmark();


        private readonly string[] _fileList;
        public BenchmarkHelper()
        {
            _fileList = Directory.GetFiles(@"files", "*.pdf");
        }

        [Benchmark(Description = "Aspose Benchmark")]
        [Arguments(4)]
        public void RunAspose(int pageCount)
        {
            _asposeBenchmark.Run(_fileList, pageCount);
        }

        [Benchmark(Description ="iText7 Benchmark")]
        [Arguments(4)]
        public void RunIText7(int pageCount)
        {
            _iText7Benchmark.Run(_fileList, pageCount);
        }

        [Benchmark(Description = "PdfSharp Benchmark")]
        [Arguments(4)]
        public void RunPdfSharp(int pageCount)
        {
            _pdfSharpBenchmark.Run(_fileList, pageCount);
        }
    }
}
