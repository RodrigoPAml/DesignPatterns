namespace DesignPatterns.Structutal.Bridge.Implementation
{
    // Implementor interface
    interface IGuiRenderer
    {
        void RenderButton(string text);
        void RenderTextBox(string text);
    }
}
