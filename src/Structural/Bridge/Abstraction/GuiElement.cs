using DesignPatterns.Structural.Bridge.Implementation;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    // Abstraction
    public abstract class GuiElement
    {
        protected IGuiRenderer renderer;

        public GuiElement(IGuiRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Render();
    }
}
