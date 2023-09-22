using DesignPatterns.Structural.Decorator.Base;
using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    public class RemoveSpaceDecorator : TextFormatter
    {
        public RemoveSpaceDecorator(ITextFormatter formatter) : base(formatter)
        {
        }

        public override string Format(string text)
        {
            return base.Format(text).Replace(" ", "");
        }
    }
}
