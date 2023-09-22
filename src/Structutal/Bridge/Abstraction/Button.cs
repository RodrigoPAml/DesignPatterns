using DesignPatterns.Structutal.Bridge.Implementation;

namespace DesignPatterns.Structutal.Bridge.Abstraction
{
    // Refined Abstraction classes representing GUI elements
    class Button : GuiElement
    {
        private string text;

        public Button(IGuiRenderer renderer, string text) : base(renderer)
        {
            this.text = text;
        }

        public override void Render()
        {
            renderer.RenderButton(text);
        }
    }
}
