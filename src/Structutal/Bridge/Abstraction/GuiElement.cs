using DesignPatterns.Structutal.Bridge.Implementation;

namespace DesignPatterns.Structutal.Bridge.Abstraction
{
    // Abstraction
    abstract class GuiElement
    {
        protected IGuiRenderer renderer;

        public GuiElement(IGuiRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Render();
    }
}
