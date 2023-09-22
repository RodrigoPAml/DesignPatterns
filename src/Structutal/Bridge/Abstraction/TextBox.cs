using DesignPatterns.Structutal.Bridge.Implementation;

namespace DesignPatterns.Structutal.Bridge.Abstraction
{
    // Refined Abstraction classes representing GUI elements
    class TextBox : GuiElement
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
