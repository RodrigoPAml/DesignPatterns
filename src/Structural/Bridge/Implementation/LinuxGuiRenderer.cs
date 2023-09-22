namespace DesignPatterns.Structural.Bridge.Implementation
{
    // Concrete Implementor classes for different operating systems
    public class LinuxGuiRenderer : IGuiRenderer
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
