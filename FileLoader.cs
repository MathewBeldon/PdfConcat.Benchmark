namespace PdfConcat.Benchmark
{
    public static class FileLoader
    {
        public static MemoryStream Get(string path)
        {
            return new MemoryStream(File.ReadAllBytes(path));
        }

        public static MemoryStream[] GetAll(string[] paths)
        {
            List<MemoryStream> _ms = new List<MemoryStream>();
            foreach (var path in paths)
            {
                _ms.Add(new MemoryStream(File.ReadAllBytes(path)));
            }
            return _ms.ToArray();
        }
    }
}
