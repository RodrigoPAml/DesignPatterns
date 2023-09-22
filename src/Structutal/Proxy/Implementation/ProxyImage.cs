using DesignPatterns.Structutal.Proxy.Interface;

namespace DesignPatterns.Structutal.Proxy.Implementation
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
