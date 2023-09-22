namespace DesignPatterns.Structutal.Bridge.Implementation
{
    // Concrete Implementor classes for different operating systems
    class LinuxGuiRenderer : IGuiRenderer
    {
        public void RenderButton(string text)
        {
            Console.WriteLine($"Linux Button: {text}");
        }

        public void RenderTextBox(string text)
        {
            Console.WriteLine($"Linux TextBox: {text}");
        }
    }
}
