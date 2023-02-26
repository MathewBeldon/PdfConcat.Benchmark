namespace PdfConcat.Benchmark
{
    public static class FileLoader
    {
        public static MemoryStream Get(string path)
        {
            return new MemoryStream(File.ReadAllBytes(path));
        }
    }
}
