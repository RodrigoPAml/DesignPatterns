using DesignPatterns.Structutal.Proxy.Interface;

namespace DesignPatterns.Structutal.Proxy.Implementation
{
    // RealObject
    class Image : IImage
    {
        private string filename;

        public Image(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }
    }
}
