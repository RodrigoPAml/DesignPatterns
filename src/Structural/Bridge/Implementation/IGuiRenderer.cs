namespace DesignPatterns.Structural.Bridge.Implementation
{
    // Implementor interface
    public interface IGuiRenderer
    {
        void RenderButton(string text);
        void RenderTextBox(string text);
    }
}
