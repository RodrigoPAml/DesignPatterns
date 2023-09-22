using DesignPatterns.Structural.Proxy.Interface;

namespace DesignPatterns.Structural.Proxy.Implementation
{
    // Proxy
    class ProxyImage : IImage
    {
        private Image realImage = null;

        private string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
                realImage = new Image(filename);

            realImage.Display();
        }
    }
}
