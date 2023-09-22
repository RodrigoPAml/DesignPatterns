using DesignPatterns.Structutal.Decorator.Base;
using DesignPatterns.Structutal.Decorator.Interface;

namespace DesignPatterns.Structutal.Decorator.Decorators
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
