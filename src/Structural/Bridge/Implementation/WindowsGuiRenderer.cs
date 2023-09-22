namespace DesignPatterns.Structural.Bridge.Implementation
{
    // Concrete Implementor classes for different operating systems
    public class WindowsGuiRenderer : IGuiRenderer
    {
        public void RenderButton(string text)
        {
            Console.WriteLine($"Windows Button: {text}");
        }

        public void RenderTextBox(string text)
        {
            Console.WriteLine($"Windows TextBox: {text}");
        }
    }
}
