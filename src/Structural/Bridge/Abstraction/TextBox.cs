using DesignPatterns.Structural.Bridge.Implementation;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    // Refined Abstraction classes representing GUI elements
    public class TextBox : GuiElement
    {
        private string text;

        public TextBox(IGuiRenderer renderer, string text) : base(renderer)
        {
            this.text = text;
        }

        public override void Render()
        {
            renderer.RenderTextBox(text);
        }
    }
}
