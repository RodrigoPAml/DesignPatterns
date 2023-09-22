using DesignPatterns.Structural.Decorator.Base;
using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    public class ToUpperDecorator : TextFormatter
    {
        public ToUpperDecorator(ITextFormatter formatter) : base(formatter)
        {
        }

        public override string Format(string text)
        {
            return base.Format(text).ToUpper();
        }
    }
}
