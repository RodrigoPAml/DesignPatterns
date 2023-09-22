using DesignPatterns.Structural.Proxy.Interface;

namespace DesignPatterns.Structural.Proxy.Implementation
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
