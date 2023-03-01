using BenchmarkDotNet.Running;

namespace PdfConcat.Benchmark
{
    public class Program
    {
        public static void Main()
        {
            _ = BenchmarkRunner.Run<BenchmarkHelper>();
        }
    }
}

//using Aspose.Pdf;
//using PdfConcat.Benchmark;
//using PdfConcat.Benchmark.Benchmarks;
//using PdfConcat.Benchmark.Benchmarks.Contracts;

//IBenchmark _iText7Benchmark = new IText7Benchmark();
//IBenchmark _asposeBenchmark1 = new AsposeBenchmarkAdd();
//IBenchmark _asposeBenchmark2 = new AsposeBenchmarkConcat();
//IBenchmark _pdfSharpBenchmark = new PdfSharpBenchmark();
//IBenchmark _ironPdfMerge = new IronPdfBenchmarkMerge();
//IBenchmark _ironPdfAppend = new IronPdfBenchmarkAppend();

//BenchmarkHelper bmh = new BenchmarkHelper();

//string[] _fileList;
//_fileList = Directory.GetFiles(@"files", "*.pdf");

//_pdfSharpBenchmark.Run(_fileList);

//for (int i = 0; i < 1000; i++)
//{
//    File.Copy(@"files/dummy.pdf", @$"files/dummy{i.ToString("000")}.pdf", true);
//}