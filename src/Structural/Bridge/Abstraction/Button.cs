using DesignPatterns.Structural.Bridge.Implementation;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    // Refined Abstraction classes representing GUI elements
    public class Button : GuiElement
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
