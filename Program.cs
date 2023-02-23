
//foreach (string pic in picList)
//{
//    Console.WriteLine(pic);
//}

using BenchmarkDotNet.Running;

namespace PdfConcat.Benchmark
{
    public class Program
    {
        public static void Main()
        {
            _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}

////using PdfSharp.Pdf.IO;
////using PdfSharp.Pdf;
////using System.Text;

//using iText.Kernel.Pdf;
//using iText.Kernel.Utils;

//string[] picList = Directory.GetFiles(@"files", "*.pdf");

//using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(picList[0]), new PdfWriter(@"C:/source/merged.pdf")))
//{
//    foreach (string pic in picList.Skip(1))
//    {
//        using (PdfDocument pdfDocument2 = new PdfDocument(new PdfReader(pic)))
//        {
//            PdfMerger merger = new PdfMerger(pdfDocument);
//            merger.Merge(pdfDocument2, 1, pdfDocument2.GetNumberOfPages());
//        }
//    }
//}