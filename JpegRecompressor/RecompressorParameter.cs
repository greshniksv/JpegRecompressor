namespace JpegRecompressor
{
    public class RecompressorParameter
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public int Quality { get; set; }
        public int ThreadCount { get; set; }
    }
}
