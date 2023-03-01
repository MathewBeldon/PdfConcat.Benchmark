using Aspose.Pdf;
using BenchmarkDotNet.Attributes;
using iText.Licensing.Base;
using PdfConcat.Benchmark.Benchmarks;
using PdfConcat.Benchmark.Benchmarks.Contracts;

namespace PdfConcat.Benchmark
{
    [MemoryDiagnoser]
    public class BenchmarkHelper
    {
        private readonly IBenchmark _iText7Benchmark = new IText7Benchmark();
        private readonly IBenchmark _asposeBenchmarkAdd = new AsposeBenchmarkAdd();
        private readonly IBenchmark _asposeBenchmarkConcat = new AsposeBenchmarkConcat();
        private readonly IBenchmark _pdfSharpBenchmark = new PdfSharpBenchmark();
        private readonly IBenchmark _ironPdfMerge = new IronPdfBenchmarkMerge();
        private readonly IBenchmark _ironPdfAppend = new IronPdfBenchmarkAppend();


        private readonly string[] _fileList;
        public BenchmarkHelper()
        {
            _fileList = Directory.GetFiles(@"files", "*.pdf");

            using (var file = new FileStream("itext.lic", FileMode.Open))
            {
                LicenseKey.LoadLicenseFile(file);
            }

            License license = new License();
            license.SetLicense("aspose.lic");

            IronPdf.License.LicenseKey = File.ReadAllText(@"iron_pdf.lic");
        }

        [Benchmark(Description = "Aspose Pages.Add")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        [Arguments(1000)]
        public void RunAspose1(int pageCount)
        {
            _asposeBenchmarkAdd.Run(_fileList.Take(pageCount).ToArray());
        }

        [Benchmark(Description = "Aspose Concatenate")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        [Arguments(1000)]
        public void RunAspose2(int pageCount)
        {
            _asposeBenchmarkConcat.Run(_fileList.Take(pageCount).ToArray());
        }

        [Benchmark(Description = "iText7")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        [Arguments(1000)]
        public void RunIText7(int pageCount)
        {
            _iText7Benchmark.Run(_fileList.Take(pageCount).ToArray());
        }

        [Benchmark(Description = "PdfSharp")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        [Arguments(1000)]
        public void RunPdfSharp(int pageCount)
        {
            _pdfSharpBenchmark.Run(_fileList.Take(pageCount).ToArray());
        }

        [Benchmark(Description = "IronPDF Merge")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        //[Arguments(1000)] takes too long 
        public void RunIronPdfMerge(int pageCount)
        {
            _ironPdfMerge.Run(_fileList.Take(pageCount).ToArray());
        }

        [Benchmark(Description = "IronPDF Append")]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(100)]
        [Arguments(1000)]
        public void RunIronPdf(int pageCount)
        {
            _ironPdfAppend.Run(_fileList.Take(pageCount).ToArray());
        }
    }
}
